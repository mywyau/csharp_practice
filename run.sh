#!/bin/bash

set -e  # Exit immediately if a command exits with a non-zero status.

# Default project to "Basics" if no argument is provided
TAG=${1:-Basics}

echo "Cleaning build..."
dotnet clean src/$TAG

# Check if the specified project exists
if [ ! -d "src/$TAG" ]; then
    echo "Error: Project 'src/$TAG' does not exist."
    exit 1
fi

echo "Running the application: $TAG"
dotnet run --project "src/$TAG"
