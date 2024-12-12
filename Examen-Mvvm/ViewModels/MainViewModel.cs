﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Examen_Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double producto1;

        [ObservableProperty]
        private double producto2;

        [ObservableProperty]
        private double producto3;

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double total;

        [RelayCommand]
        private void Calcular()
        {
            Subtotal = Producto1 + Producto2 + Producto3;
            if (Subtotal >= 10000)
            {
                Descuento = Subtotal * 0.30;
            }
            else if (Subtotal >= 5000)
            {
                Descuento = Subtotal * 0.20;
            }
            else if (Subtotal >= 1000)
            {
                Descuento = Subtotal * 0.10;
            }
            else
            {
                Descuento = 0;
            }
            Total = Subtotal - Descuento;
        }

        [RelayCommand]
        private void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}

