// pch.h : Il s'agit d'un fichier d'en-tête précompilé.
// Les fichiers listés ci-dessous sont compilés une seule fois, ce qui améliore les performances de génération des futures builds.
// Cela affecte également les performances d'IntelliSense, notamment la complétion du code et de nombreuses fonctionnalités de navigation du code.
// Toutefois, les fichiers listés ici sont TOUS recompilés si l'un d'entre eux est mis à jour entre les builds.
// N'ajoutez pas de fichiers fréquemment mis à jour ici, car cela annule les gains de performance.

#ifndef PCH_H
#define PCH_H
#define DLL_EXPORT __declspec(dllexport)

// ajouter les en-têtes à précompiler ici
#include <windows.h>
#include <msclr/marshal_cppstd.h>
#include <string>
#include <iostream>
#include <filesystem>

#endif //PCH_H
