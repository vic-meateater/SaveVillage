using System;
using TMPro;
using UnityEngine;
using R3;

namespace SaveVillage
{
    public class WorkersView: MonoBehaviour, IDisposable
    {
        [SerializeField] private TMP_Text _workersCountDownText;
        
        private DisposableBag _disposableBag;

        public void Init(IWorkersViewModel workersViewModel)
        {
            workersViewModel.WorkersCountDown
                .Subscribe(value => _workersCountDownText.text = value.ToString())
                .AddTo(ref _disposableBag);
        }
        public void Dispose()
        {
            _disposableBag.Dispose();
        }
    }
}