
# react-native-dream-life-of-mechanic

## Getting started

`$ npm install react-native-dream-life-of-mechanic --save`

### Mostly automatic installation

`$ react-native link react-native-dream-life-of-mechanic`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-dream-life-of-mechanic` and add `RNDreamLifeOfMechanic.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDreamLifeOfMechanic.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDreamLifeOfMechanicPackage;` to the imports at the top of the file
  - Add `new RNDreamLifeOfMechanicPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-dream-life-of-mechanic'
  	project(':react-native-dream-life-of-mechanic').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-dream-life-of-mechanic/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-dream-life-of-mechanic')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDreamLifeOfMechanic.sln` in `node_modules/react-native-dream-life-of-mechanic/windows/RNDreamLifeOfMechanic.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Dream.Life.Of.Mechanic.RNDreamLifeOfMechanic;` to the usings at the top of the file
  - Add `new RNDreamLifeOfMechanicPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDreamLifeOfMechanic from 'react-native-dream-life-of-mechanic';

// TODO: What to do with the module?
RNDreamLifeOfMechanic;
```
  