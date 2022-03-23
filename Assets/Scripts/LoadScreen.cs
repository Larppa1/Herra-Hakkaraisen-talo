using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TIKO4A2021
{
    public class LoadScreen : MonoBehaviour{
        public enum LoadingState{
            None,
            Started,
            InProgress
        }
        public const string LoaderName = "LoadScreen";
        public static LoadScreen Current{
            get;
            private set;
        }
        private LoadingState state = LoadingState.None;
        private Scene originalScene;
        private Scene loadScreen;
        private string nextSceneName;

        void Awake(){
            if(Current == null){
                    Current = this;
            }else{
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
        }

        private void OnEnable(){
            SceneManager.sceneLoaded += OnLevelLoaded;
        }
        private void OnDisable(){
            SceneManager.sceneLoaded -= OnLevelLoaded;
        }
        public void LoadLevel(string SceneName){
            nextSceneName = SceneName;
            originalScene = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync(LoaderName, LoadSceneMode.Additive);
            state = LoadingState.Started;
        }
        private void OnLevelLoaded(Scene scene, LoadSceneMode mode){
            switch(state){
                case LoadingState.Started:
                    loadScreen = scene;
                    foreach(GameObject item in loadScreen.GetRootGameObjects()){
                        Fader fader = item.GetComponentInChildren<Fader>();
                        if(fader != null){
                            float fadeTime = fader.FadeIn();
                            StartCoroutine(ContinueLoad(fadeTime));
                            break;
                        }
                    }
                break;
                case LoadingState.InProgress:
                    foreach(GameObject item in loadScreen.GetRootGameObjects()){
                        Fader fader = item.GetComponentInChildren<Fader>();
                        if(fader != null){
                            float fadeTime = fader.FadeOut();
                            StartCoroutine(FinalizeLoad(fadeTime));
                            state = LoadingState.None;
                            break;
                        }
                    }
                break;
                case LoadingState.None:
                break;
            }
        }

        private IEnumerator ContinueLoad(float waitTime){
            yield return new WaitForSeconds(waitTime);//odottaa waittimen verran
            // sitten jatkaa seuraavalta riviltä
            SceneManager.UnloadSceneAsync(originalScene);
            SceneManager.LoadSceneAsync(nextSceneName, LoadSceneMode.Additive);
            state = LoadingState.InProgress;
        }
        private IEnumerator FinalizeLoad(float waitTime){
            yield return new WaitForSeconds(waitTime);
            SceneManager.UnloadSceneAsync(loadScreen);
            state = LoadingState.None;
        }

    }
}
