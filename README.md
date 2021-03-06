# RefactorPractice
重構-改善既有程式的設計Lab

使用C#改寫書上的範例

## 重構的定義：
不改變外在的行為的前提下，對程式碼做出修正，以改進程式的內部結構。本質上來說，重構就是在`程式碼寫好之後改進它的設計`

## 重構的原則：
* 需要有穩定且堅固的測試機制
* 以微小步伐修改程式，如果引入錯誤便可以很容易發現
* 如果覺得比較困難增加新的功能，就先重構後再增加
* 只有寫出人類容易理解的程式碼，才是優秀的程式員

## 兩頂帽子 - 重構與增加新功能
* 增加新功能：不應該修改既有程式碼，只管增加新功能以通過測試
* 重構：不能增加新功能，只管修改程式結構。只在絕對必要的時刻才修改測試。

## 為何要重構?
* 改進軟體設計：一個主要的方向就是`消除重複的程式碼`。
* 使軟體更容易被理解：提高可讀性。
* 幫你找到Bug
* 幫你提高編程速度

## 何時重構?
* 三次法則：事不過三，三則重構
* 增加功能的時候重構
* 修改錯誤的時候重構
* Code Review的時候重構

## 程式碼的壞味道(Bad Smell)
* 重複的程式碼(Duplicated Code)
* 過長的函式(Long Method)
* 過大的類別(Large Class)
* 過長的參數列(Large Parameter List)
* 發散式變化(Divergent Change)
* 散彈式修改(Shotgun Surgery)
* 依戀情節(Feature Envy)
* 資料泥團(Data Clump)
* 基本型別偏執(Primitive Obsession)
* Switch case 
* 平行繼承體系(Parallel Inheritance Hierarchies)
* 冗員類別(Lazy Class)
* 誇大其談未來性(Speculative Generality)
* 暫時欄位(Temporary Field)
* 過度耦合的訊息鏈(Message Chains)
* 中間轉手人(Middle Man)
* 狎暱關係(inappropriate Intimacy)
* 異曲同工的類別(Alternative Classes With Different Interfaces)
* 不完美的程式庫類別(Incomplete Library Class)
* 純資料類別(Data Class)
* 被拒絕的遺贈(Refused Bequest)
* 過多的註釋(Comments)

## 重構手法

### 重新組織函式(Composing Methods)
* [提煉函式(Extract Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/ExtractMethod)
* [行內函式(Inline Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/InlineMethod)
* [行內暫時變數(Inline Temp)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/InlineTemp)
* [用回傳函式替換暫時變數(Replace Temp With Query)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/ReplaceTempWithQuery)
* [以變數解釋運算式用途(Introduce Explaining Variable)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/IntroduceExplainingVariable)
* [剖解暫時變數(Split Temporary Variable)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/SplitTemporaryVariable)
* [移除對參數賦值(Remove Assignments To Parameters)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/RemoveAssignmentsToParameters)
* [用函式物件替換函式(Replace Method With MethodObject)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/ReplaceMethodWithMethodObject)
* [替換演算法(Substitute Algorithm)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/SubstituteAlgorithm)

### 在物件中間搬移特性(Moving Features Between Objects)
* [移動函式(Move Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/MoveMethod)
* [移動欄位(Move Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/MoveField)
* [提煉類別(Move Class)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/ExtractClass)
* [行內類別(Inline Class)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/InlineClass)
* [隱藏委託關係(Hide Delegate)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/HideDelegate)
* [移除中間人(Remove Middle Man)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/RemoveMiddleMan)
* [引入外加函式(Introduce Foreign Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/IntroduceForeignMethod)
* [引入區域性擴展(Introduce Local Extension)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/IntroduceLocalExtension)

### 重新組織資料(Organizing Data)
* [自我封裝欄位(Self Encapsulate Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/SelfEncapsulateField)
* [以物件取代資料值(Replace Data Value With Object)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceDataValueWithObject)
* [將實值物件改為參考物件(Change Value To Reference)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ChangeValueToReference)
* [將參考物件改為實值物件(Change Reference To Value)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ChangeReferenceToValue)
* [以物件取代陣列(Replace Array With Object)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceArrayWithObject)
* [複製被監視的資料(Duplicate Observed Data)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/DuplicateObservedData)
* [將單向關聯改為雙向(Change Unidirectional Association To Bidirectonal)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ChangeUnidirectionalAssociationToBidirectonal)
* [將雙向關聯改為單向(Change Bidirectonal Association To Unidirectional)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ChangeBidirectonalAssociationToUnidirectional)
* [以符號常數(字面常數)取代魔術數字 (Replace Magic Number With Symbolic Constant)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceMagicNumberWithSymbolicConstant)
* [封裝欄位(Encapsulate Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/EncapsulateField)
* [封裝群集(Encapsulate Collection)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/EncapsulateCollection)
* [以資料類別取代紀錄(Replace Record With Data Class)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceRecordWithDataClass)
* [以類別取代型別代碼(Replace TypeCode With Class)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceTypeCodeWithClass)
* [以子類別取代型別代碼(Replace Type Code With Subclasses)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceTypeCodeWithSubclasses)
* [以State/Strategy取代型別代碼(Replace Type Code With State/Strategy)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceTypeCodeWithStateOrStrategy)
* [以欄位取代子類別(Replace Subclass With Fields)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceSubclassWithFields)

### 簡化條件式(Simplifying Conditional Expressions)
* [分解條件式(Decompose Conditional)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/DecomposeConditional)
* [合併條件式(Consolidate Conditional Expression)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/ConsolidateConditionalExpression)
* [合併重複的條件片段(Consolidate Duplicate Conditional Fragments)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/ConsolidateDuplicateConditionalFragments)
* [移除控制旗標(Remove Control Flag)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/RemoveControlFlag)
* [以衛述句取代巢狀條件式(Replace Nested Conditional With Guard Clauses)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/ReplaceNestedConditionalWithGuardClauses)
* [以多型取代條件式(Replace Conditional With Polymorphism)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/ReplaceConditionalWithPolymorphism)
* [引入Null Object(Introduce NullObject)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/IntroduceNullObject)
* [引入斷言(Introduce Assertion)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/SimplifyingConditionalExpressions/IntroduceAssertion)

### 簡化函式呼叫(Making Method Calls Simpler)
* [重新命名函式(Rename Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/RenameMethod)
* [添加參數(Add Parameter)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/AddParameter)
* [移除參數(Remove Parameter)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/RemoveParameter)
* [將查詢函式和修改函式分離(Separate Query From Modifier)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/SeparateQueryFromModifier)
* [令函式攜帶參數(Parameterize Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/ParameterizeMethod)
* [以明確函式取代參數(Replace Parameter With Explicit Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/ReplaceParameterWithExplicitMethod)
* [保持物件完整(Preserve Whole Object)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/PreserveWholeObject)
* [以函式取代參數(Replace Parameter With Methods)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/ReplaceParameterWithMethods)
* [引入參數物件(Introduce Parameter Objects)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/IntroduceParameterObject)
* [移除設值函式(Remove Setting Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/RemoveSettingMethod)
* [隱藏某個函式(Hide Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/HideMethod)
* [以「工廠函式」取代「建構式」(Replace Constructor With Factory Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/ReplaceConstructorWithFactoryMethod)
* [封裝「向下轉型」動作 (Encapsulate Downcast)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/EncapsulateDowncast)
* [以異常取代錯誤碼(Replace Error Code With Exception)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/ReplaceErrorCodeWithException)
* [以測試取代異常(Replace Exception With Test)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MakingMethodCallsSimpler/ReplaceExceptionWithTest)

### 處理概括關係(Deal With Generalization)
* [欄位上移(Pull Up Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/PullUpField)
* [函式上移(Pull Up Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/PullUpMethod)
* [建構式本體上移(Pull Up Constrctor Body)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/PullUpConstrctorBody)
* [函式下移(Push Down Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/PushDownMethod)
* [欄位下移(Push Down Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/PushDownField)
* [提煉子類別(Extract Subclass)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/ExtractSubClass)
* [提煉超類別(Extract Superclass)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/ExtractSuperclass)
* [提煉介面(Extract Interface)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/ExtractInterface)
* [摺疊繼承關係(Collapse Hierarchy)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/CollapseHierarchy)
* [塑造模板函式(Form Template Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/FormTemplateMethod)
* [以委託取代繼承 (Replace Inheritance With Delegation)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/ReplaceInheritanceWithDelegation)
* [以繼承取代委託(Replace Delegation With Inheritance)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/DealWithGeneralization/ReplaceDelegationWithInheritance)

### 大型重構(Big Refactoring)
* [以繼承取代委託(Replace Delegation With Inheritance)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/BigRefactoring/TeaseApartInheritance)
* [將程序式設計轉化為物件設計(Convert Procedural Design To Objects)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/BigRefactoring/ConvertProceduralDesignToObjects)
* [將領域和表述/顯示分離(Separate Domain From Presentation)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/BigRefactoring/SeparateDomainFromPresentation)
* [提煉繼承體系(Extract Hierarchy)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/BigRefactoring/ExtractHierarchy)

## 重構的現實

### 為什麼開發者不願意重構他們程式
* 不知道如何重構
* 如果這些利益是需要長時間才能展現的，何必現在付出努力? 長遠看來，當專案收穫這些利益的時候，或許自己已經不在職位上了
* 程式碼重構是額外的工作，老闆付錢給你，是要你增加新功能
* 重構可能破壞現有程式

### 如何重構，在哪裡重構
* 使用自動化工具來識別哪裡需要重構，以及提供重構的建議

### 重構以求短期利益
* 重構帶來的短期利益是讓軟體更好修改、更易維護
* 長期的願景是程式員或程式開發團隊如何開發並維護自己的軟體

### 降低重構帶來的額外開銷
* 目前有一些工具和技術，可以使重構快速而相對無痛的完成
* 重構雖然需要額外開銷，但可以從在程式開發的其他階段協助降低所需心力即滯怠時間獲得補償
* 儘管重構開銷太大，但當他成為開發規則的一部分，就不會覺得他費事，反而會覺得是不可或缺。

### 安全的進行重構
* 相信自己的編碼能力
* 相信編譯器會捕捉遺漏的錯誤
* 相信測試套件能捕捉你和編譯器都遺漏的錯誤
* 相信程式碼複審(code review)能捕捉你、編譯器、測試套件都遺漏的錯誤

### 安全重構的侷限性
* 程式員有可能犯錯
* 有編譯器無法捕捉的錯誤，特別是與繼承相關的作用域錯誤
* 無法保證測試套件涵蓋所有可能情況
* 程式碼複審人員可能無法徹底檢查別人的程式碼

### 學習重構的技術
* 隨時挑一個目標：某個程式碼開始發臭，就應該將問題解決掉。你應該朝目標前進，達成後就停止。
* 沒把握就停下來：你無法證明自己所做的一切還能夠保持程式的原意，就停下來，有改善的成果就發布，沒有的話就撤銷。
* 學習原路返回：當重構已經失控時，要果斷放棄，回到上一個測試可以通過的程式碼版本。
* 二重奏：兩人結對重構，你的搭檔會看到與想到你沒發現的東西，當你的夥伴不知道你在重構什麼東西，通常自己也會不知道在重構什麼。在重構之前先與夥伴討論目標與方向，這樣夥伴才能指出你的錯誤。
* 