﻿namespace Engine

module Domain = 

    type SpecificRequest = 
        | Song of string
        | Album of string
        | Artist of string
 
    type ThemeRequest = 
        | Genre of string
        | Tempo of string
        
    type Request = 
        | SpecificRequest of SpecificRequest
        | ThemeRequest of ThemeRequest