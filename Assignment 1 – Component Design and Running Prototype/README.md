# Campus Café Ordering System – Component-Based Software Design

مشروع مادة هندسة البرمجيات القائمة على المكونات (**Component-Based Software Engineering**). يهدف المشروع إلى بناء تطبيق كونسول بلغة C# لإدارة طلبات مقهى جامعي مع تطبيق مبادئ فصل المكونات، العقود البرمجية (Interfaces)، وحقن التبعيات (Dependency Injection)، وتقييم صفات الجودة البرمجية الأربع.

---

## 📋 Checkpoint 1: Component Design and Running Prototype

* **موعد التسليم (Due Date):** الأربعاء 25 نوفمبر 2026، الساعة 12:00 ظهراً

### جدول توزيع المهام والملكية التقنية

| العضو | المكون البرمجي المسؤول عنه (`Program.cs`) | مهام التوثيق في تقرير `Design.pdf` | مهام الجودة والتسليم والمراجعة |
| :--- | :--- | :--- | :--- |
| **عبدالرحمن**<br>*(الممثل)* | **محرك الطلبات والدمج (Order Service & Main):**<br>• بناء الفئة الأولية لـ `OrderService` باستخدام Constructor Injection.<br>• كتابة دالة `Main` لربط الكائنات وتشغيل المثال العملي (Worked Example) بدون خصم. | • رسم مخطط الاعتماديات (**Dependency Diagram**) الذي يوضح العلاقة بين `Main` والواجهات والتطبيقات.<br>• كتابة فقرة شرح كيفية تجميع الكائنات (Object Assembly) في `Main`. | • **صفة الجودة:** **Correctness** (كتابة صف الصفة في مصفوفة الجودة: الهدف القابل للقياس وخطة التحقق).<br>• تجميع ملف `Design.pdf` (بحد أقصى 4 صفحات)، وكتابة `README.txt` و `Output.txt` بعد التشغيل على .NET Fiddle.<br>• **مراجعة كود:** إيهاب. |
| **إيهاب** | **الكتالوج ونماذج البيانات (Catalogue & Data Models):**<br>• تعريف واجهة `IProductCatalogue`.<br>• بناء `InMemoryCatalogue` بالمنتجات الأربعة الثابتة (`P01`–`P04`) مع التحقق من المعرفات.<br>• بناء فئات البيانات: `Product`, `OrderLine`, `OrderSummary`, `CalculatedLine`. | • كتابة العقد البرمجي الكامل (**Interface Contract**) لواجهة `IProductCatalogue` (المدخلات، المخرجات، والاستثناءات المتوقعة مثل `ArgumentException`).<br>• توثيق هيكل البيانات (Data Models). | • **صفة الجودة:** **Robustness** (كتابة صف الصفة في مصفوفة الجودة: كيف يحمي الكتالوج والـ Service النظام من المدخلات الفارغة أو غير المعروفة).<br>• **مراجعة كود:** عمر. |
| **عمر** | **سياسات التسعير (Pricing & Contracts):**<br>• تعريف واجهة `IPricingPolicy` (دالة `Apply` وخاصية `Name`).<br>• تطبيق فئة `NoDiscount` التي تعيد المجموع الفرعي كما هو وتتحقق من القيم السالبة. | • كتابة العقد البرمجي الكامل (**Interface Contract**) لواجهة `IPricingPolicy` (القيود السلوكية وقواعد القيم السالبة والصفر). | • **صفة الجودة:** **Modifiability** (كتابة صف الصفة في مصفوفة الجودة: خطة إضافة `EmployeeDiscount` مستقبلاً دون تعديل `OrderService`).<br>• تنسيق جدول المساهمات والمراجعة (Contribution & Review Table) في التقرير.<br>• **مراجعة كود:** سعود. |
| **سعود** | **الفواتير والاختبارات المؤتمتة (Receipts & Automated Tests):**<br>• تعريف واجهة `IReceiptFormatter`.<br>• بناء `DetailedReceiptFormatter` لعرض تفاصيل الفاتورة.<br>• كتابة نظام الاختبارات الآلية في `Program.cs` وتنفيذ الاختبارات الثلاثة المطلوبة (`T01`, `T04`, `T06`). | • كتابة العقد البرمجي الكامل (**Interface Contract**) لواجهة `IReceiptFormatter`.<br>• توثيق آلية عمل الاختبارات الثلاثة (`T01`, `T04`, `T06`) في التقرير. | • **صفة الجودة:** **Testability** (كتابة صف الصفة في مصفوفة الجودة: كيف يسهل فصل `OrderSummary` وحقن التبعيات عملية الاختبار الآلي).<br>• التحقق من أن مخرجات الاختبارات تطبع `PASS/FAIL` بوضوح.<br>• **مراجعة كود:** عبدالرحمن. |

---

## 🗓️ خطة العمل الزمنية (Checkpoint 1)

1. **المرحلة 1 — الاتفاق على الواجهات:** الاتفاق على أسماء الدوال والكلاسات المشتركة (`IProductCatalogue`, `IPricingPolicy`, `IReceiptFormatter`, `Product`, `OrderSummary`) لتجنب التعارض.
2. **المرحلة 2 — البرمجة والتوثيق الفردي:** كتابة كل عضو للجزء البرمجي الخاص به وتسليم فقرته المخصصة في تقرير `Design.pdf` (الحد الأقصى للتقرير 4 صفحات).
3. **المرحلة 3 — الدمج والاختبار على .NET Fiddle:** دمج الكود في ملف `Program.cs` واحد، إجراء مراجعة الكود المتبادلة (Code Review)، وتشغيل الكود على [dotnetfiddle.net](https://dotnetfiddle.net/) لاستخراج `Output.txt`.
4. **المرحلة 4 — الـ Reflections والتسليم النهائي:**
   * يكتب كل عضو ملف `Reflection_S1_StudentID.pdf` (200–300 كلمة).
   * يرفع **عبدالرحمن** ملف `G##_S1_ID.zip` محتويًا على: `Program.cs`, `Design.pdf`, `README.txt`, `Output.txt`, وملف الـ Reflection الخاص به.
   * يرفع **إيهاب وعمر وسعود** كلٌ ملف `G##_S1_ID.zip` محتويًا على: ملف الـ Reflection الخاص به + ملف `Team.txt`.


## 1. الواجهات الإلزامية (Mandatory Interfaces - Checkpoint 1)

*(يجب الالتزام بنفس الأسماء وتوقيعات الدوال حرفياً كما وردت في مواصفات المشروع)*

| اسم الواجهة | الدوال والخصائص المطلوبة داخلها | المسؤول |
| :--- | :--- | :--- |
| **`IProductCatalogue`** | `Product GetById(string productId);` | إيهاب |
| **`IPricingPolicy`** | `string Name { get; }`<br>`decimal Apply(decimal subtotal);` | عمر |
| **`IReceiptFormatter`** | `string Format(OrderSummary summary);` | سعود |

---

## 2. فئات البيانات الأساسية (Data Models - Checkpoint 1)

*(أسماء `Product` و `OrderSummary` إلزامية حرفياً، أما البقية فهي أسماء موحدة للفريق)*

| اسم الكلاس | الخصائص (Properties) | الوصف والمسؤول |
| :--- | :--- | :--- |
| **`Product`** *(إلزامي)* | `string Id`<br>`string Name`<br>`decimal UnitPrice` | يمثل المنتج الواحد في الكتالوج (إيهاب) |
| **`OrderLine`** | `string ProductId`<br>`int Quantity` | يمثل السطر المطلوب في الطلب من العميل (إيهاب) |
| **`CalculatedLine`** | `string ProductId`<br>`string ProductName`<br>`int Quantity`<br>`decimal UnitPrice`<br>`decimal LineTotal` | يمثل السطر بعد حساب سعره وإجماليه (إيهاب) |
| **`OrderSummary`** *(إلزامي)* | `IReadOnlyList<CalculatedLine> Lines`<br>`string PolicyName`<br>`decimal Subtotal`<br>`decimal DiscountAmount`<br>`decimal FinalTotal` | ملخص الطلب النهائي الذي يُمرَّر لمُنسق الفاتورة (إيهاب) |