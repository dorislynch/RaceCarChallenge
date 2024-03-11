
# react-native-race-car-challenge

## Getting started

`$ npm install react-native-race-car-challenge --save`

### Mostly automatic installation

`$ react-native link react-native-race-car-challenge`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-race-car-challenge` and add `RNRaceCarChallenge.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRaceCarChallenge.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRaceCarChallengePackage;` to the imports at the top of the file
  - Add `new RNRaceCarChallengePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-race-car-challenge'
  	project(':react-native-race-car-challenge').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-race-car-challenge/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-race-car-challenge')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRaceCarChallenge.sln` in `node_modules/react-native-race-car-challenge/windows/RNRaceCarChallenge.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Race.Car.Challenge.RNRaceCarChallenge;` to the usings at the top of the file
  - Add `new RNRaceCarChallengePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRaceCarChallenge from 'react-native-race-car-challenge';

// TODO: What to do with the module?
RNRaceCarChallenge;
```
  