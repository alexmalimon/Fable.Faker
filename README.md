# Fable.Faker 

[Faker](http://marak.github.io/faker.js/) integration with Fable, made with :heart:

## Installation (manual)
- Install this library from nuget
```
paket add Fable.Faker --project /path/to/Project.fsproj
```
- Install faker from npm (version 4.x)
```
npm install faker 4.1.0 --save
yarn add faker@4.1.0
```
### All Locales Code Sample
This is an examples of `Faker` name details generation on english.

```fs
All.faker.fake "{{name.lastName}}, {{name.firstName}} {{name.suffix}}"
// or 
All.faker.name.firstName()
```

### Single Locale Code Sample
This is an examples of `Faker` name details generation on chinese.

```fs
ZhCn.faker.fake "{{name.lastName}}, {{name.firstName}} {{name.suffix}}"
// or 
ZhCn.faker.name.firstName()
```