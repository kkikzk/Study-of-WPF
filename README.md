# Study-of-WPF
WPF勉強用のプロジェクト

## 環境
- Visual Studio 2019 16.9

---
## Case01
.NET5のプロジェクトを追加してみよう。  
![](./res/README/2020-11-14-10-20-59.png)  

NETSDK1173のワーニングがでるので抑制してください。  
![](./res/README/2020-11-14-10-24-12.png)

---
## Case02
TextBlockをウィンドウに配置して『Hello world!!』と表示してみよう。  
![](./res/README/2020-11-14-10-27-20.png)

---
## Case03
ViewとViewModelを理解する。  
Case02をDataBindingで実現してみよう。  
どういう形でも良いので、TextBlockに表示する文字列をDataBindingでViewModelのデータを表示するようにしてみてください。   

---
### Case04
INotifyPropertyChangedインターフェイスを理解する。  
以下のイメージで、TextBoxに入力された文字列を大文字に変換してリアルタイムでTextBlockコントロールに表示するようにしてみてください。  
![](./res/README/2020-11-14-11-28-53.png)

---
### Case05
ICommandインターフェイスを理解する。
まずはTextBlockコントロールに表示されている文字列を、ボタン押下でDebug出力してみてください。
それができたらボタン押下でTextBoxコントロールとTextBlockコントロールに表示されている文字をクリアできるようにしてみてください。
![](./res/README/2020-11-16-17-30-56.png)
