﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace NetworkExtensions.Framework
{
    public static class ItemClassExtensions
    {
        public static ItemClass Clone(this ItemClass itemClass, string newName)
        {
            var newClass = ScriptableObject.CreateInstance<ItemClass>();
            newClass.m_layer = itemClass.m_layer;
            newClass.m_level = itemClass.m_level;
            newClass.m_service = itemClass.m_service;
            newClass.m_subService = itemClass.m_subService;
            newClass.hideFlags = itemClass.hideFlags;
            newClass.name = newName;

            return newClass;
        }
    }
}
