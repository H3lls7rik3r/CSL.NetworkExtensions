﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColossalFramework;
using UnityEngine;

namespace NetworkExtensions.Framework
{
    public class TexturesSet
    {
        private Texture2D _mainTex;
        public Texture2D MainTex
        {
            get
            {
                if (_mainTex == null)
                {
                    if (!_mainTexPath.IsNullOrWhiteSpace())
                    {
                        _mainTex = TextureManager.instance.GetTexture(_mainTexPath);
                    }
                }

                return _mainTex;
            }
        }

        private Texture2D _aprMap;
        public Texture2D APRMap
        {
            get
            {
                if (_aprMap == null)
                {
                    if (!_aprMapPath.IsNullOrWhiteSpace())
                    {
                        _aprMap = TextureManager.instance.GetTexture(_aprMapPath);
                    }
                }

                return _aprMap;
            }
        }

        private Texture2D _xysMap;
        public Texture2D XYSMap
        {
            get
            {
                if (_xysMap == null)
                {
                    if (!_xysMapPath.IsNullOrWhiteSpace())
                    {
                        _xysMap = TextureManager.instance.GetTexture(_xysMapPath);
                    }
                }

                return _xysMap;
            }
        }

        private readonly string _mainTexPath;
        private readonly string _aprMapPath;
        private readonly string _xysMapPath;

        public TexturesSet(string mainTexPath, string aprMapPath = null, string xysMapPath = null)
        {
            _mainTexPath = mainTexPath;
            _aprMapPath = aprMapPath;
            _xysMapPath = xysMapPath;
        }
    }
}
