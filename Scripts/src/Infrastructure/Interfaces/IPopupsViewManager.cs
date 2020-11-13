﻿using System;
using PopupsModule.src.Infrastructure.Entities;

namespace PopupsModule.src.Infrastructure.Interfaces
{
    public interface IPopupsViewManager<in T> where T : PopupEntityBase
    {
        PopupViewBase CurrentOpenedPopup { get; }
        
        bool IsAnyOpenedPopups { get; }
        
        void Open(T popupData, Action<PopupViewBase> onOpened = null, Action onFail = null);

        void Close(T popupData, Action onClosed = null, Action onFail = null);
    }
}
