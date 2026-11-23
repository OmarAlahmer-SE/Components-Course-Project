<div dir="rtl" align="right">

# Campus Café Ordering System – Component-Based Software Design

مشروع مادة هندسة البرمجيات القائمة على المكونات (**Component-Based Software Engineering**). يهدف المشروع إلى بناء تطبيق كونسول بلغة C# لإدارة طلبات مقهى جامعي مع تطبيق مبادئ فصل المكونات، العقود البرمجية (Interfaces)، وحقن التبعيات (Dependency Injection)، وتقييم صفات الجودة البرمجية الأربع.

---

## 📋 Checkpoint 1: Component Design and Running Prototype

* **الممثل الرسمي للمجموعة (Group Representative):** عبدالرحمن
* **موعد التسليم (Due Date):** الأربعاء 25 نوفمبر 2026، الساعة 12:00 ظهراً

### جدول توزيع المهام والملكية التقنية

<table dir="rtl">
  <thead>
    <tr>
      <th align="right">العضو</th>
      <th align="right">المكون البرمجي المسؤول عنه (<code>Program.cs</code>)</th>
      <th align="right">مهام التوثيق في تقرير <code>Design.pdf</code></th>
      <th align="right">مهام الجودة والتسليم والمراجعة</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td align="right"><strong>عبدالرحمن</strong><br><em>(الممثل)</em></td>
      <td align="right">
        <strong>محرك الطلبات والدمج (Order Service & Main):</strong><br>
        • بناء الفئة الأولية لـ <code>OrderService</code> باستخدام Constructor Injection.<br>
        • كتابة دالة <code>Main</code> لربط الكائنات وتشغيل المثال العملي (Worked Example) بدون خصم.
      </td>
      <td align="right">
        • رسم مخطط الاعتماديات (<strong>Dependency Diagram</strong>) الذي يوضح العلاقة بين <code>Main</code> والواجهات والتطبيقات.<br>
        • كتابة فقرة شرح كيفية تجميع الكائنات (Object Assembly) في <code>Main</code>.
      </td>
      <td align="right">
        • <strong>صفة الجودة:</strong> <strong>Correctness</strong> (كتابة صف الصفة في مصفوفة الجودة: الهدف القابل للقياس وخطة التحقق).<br>
        • تجميع ملف <code>Design.pdf</code> (بحد أقصى 4 صفحات)، وكتابة <code>README.txt</code> و <code>Output.txt</code> بعد التشغيل على .NET Fiddle.<br>
        • <strong>مراجعة كود:</strong> إيهاب.
      </td>
    </tr>
    <tr>
      <td align="right"><strong>إيهاب</strong></td>
      <td align="right">
        <strong>الكتالوج ونماذج البيانات (Catalogue & Data Models):</strong><br>
        • تعريف واجهة <code>IProductCatalogue</code>.<br>
        • بناء <code>InMemoryCatalogue</code> بالمنتجات الأربعة الثابتة (<code>P01</code>–<code>P04</code>) مع التحقق من المعرفات.<br>
        • بناء فئات البيانات: <code>Product</code>, <code>OrderLine</code>, <code>OrderSummary</code>, <code>CalculatedLine</code>.
      </td>
      <td align="right">
        • كتابة العقد البرمجي الكامل (<strong>Interface Contract</strong>) لواجهة <code>IProductCatalogue</code> (المدخلات، المخرجات، والاستثناءات المتوقعة مثل <code>ArgumentException</code>).<br>
        • توثيق هيكل البيانات (Data Models).
      </td>
      <td align="right">
        • <strong>صفة الجودة:</strong> <strong>Robustness</strong> (كتابة صف الصفة في مصفوفة الجودة: كيف يحمي الكتالوج والـ Service النظام من المدخلات الفارغة أو غير المعروفة).<br>
        • <strong>مراجعة كود:</strong> عمر.
      </td>
    </tr>
    <tr>
      <td align="right"><strong>عمر</strong></td>
      <td align="right">
        <strong>سياسات التسعير (Pricing & Contracts):</strong><br>
        • تعريف واجهة <code>IPricingPolicy</code> (دالة <code>Apply</code> وخاصية <code>Name</code>).<br>
        • تطبيق فئة <code>NoDiscount</code> التي تعيد المجموع الفرعي كما هو وتتحقق من القيم السالبة.
      </td>
      <td align="right">
        • كتابة العقد البرمجي الكامل (<strong>Interface Contract</strong>) لواجهة <code>IPricingPolicy</code> (القيود السلوكية وقواعد القيم السالبة والصفر).
      </td>
      <td align="right">
        • <strong>صفة الجودة:</strong> <strong>Modifiability</strong> (كتابة صف الصفة في مصفوفة الجودة: خطة إضافة <code>EmployeeDiscount</code> مستقبلاً دون تعديل <code>OrderService</code>).<br>
        • تنسيق جدول المساهمات والمراجعة (Contribution & Review Table) في التقرير.<br>
        • <strong>مراجعة كود:</strong> سعود.
      </td>
    </tr>
    <tr>
      <td align="right"><strong>سعود</strong></td>
      <td align="right">
        <strong>الفواتير والاختبارات المؤتمتة (Receipts & Automated Tests):</strong><br>
        • تعريف واجهة <code>IReceiptFormatter</code>.<br>
        • بناء <code>DetailedReceiptFormatter</code> لعرض تفاصيل الفاتورة.<br>
        • كتابة نظام الاختبارات الآلية في <code>Program.cs</code> وتنفيذ الاختبارات الثلاثة المطلوبة (<code>T01</code>, <code>T04</code>, <code>T06</code>).
      </td>
      <td align="right">
        • كتابة العقد البرمجي الكامل (<strong>Interface Contract</strong>) لواجهة <code>IReceiptFormatter</code>.<br>
        • توثيق آلية عمل الاختبارات الثلاثة (<code>T01</code>, <code>T04</code>, <code>T06</code>) في التقرير.
      </td>
      <td align="right">
        • <strong>صفة الجودة:</strong> <strong>Testability</strong> (كتابة صف الصفة في مصفوفة الجودة: كيف يسهل فصل <code>OrderSummary</code> وحقن التبعيات عملية الاختبار الآلي).<br>
        • التحقق من أن مخرجات الاختبارات تطبع <code>PASS/FAIL</code> بوضوح.<br>
        • <strong>مراجعة كود:</strong> عبدالرحمن.
      </td>
    </tr>
  </tbody>
</table>

---

## 🗓️ خطة العمل الزمنية (Checkpoint 1)

1. **المرحلة 1 — الاتفاق على الواجهات:** الاتفاق على أسماء الدوال والكلاسات المشتركة (`IProductCatalogue`, `IPricingPolicy`, `IReceiptFormatter`, `Product`, `OrderSummary`) لتجنب التعارض.
2. **المرحلة 2 — البرمجة والتوثيق الفردي:** كتابة كل عضو للجزء البرمجي الخاص به وتسليم فقرته المخصصة في تقرير `Design.pdf` (الحد الأقصى للتقرير 4 صفحات).
3. **المرحلة 3 — الدمج والاختبار على .NET Fiddle:** دمج الكود في ملف `Program.cs` واحد، إجراء مراجعة الكود المتبادلة (Code Review)، وتشغيل الكود على [dotnetfiddle.net](https://dotnetfiddle.net/) لاستخراج `Output.txt`.
4. **المرحلة 4 — الـ Reflections والتسليم النهائي:**
   * يكتب كل عضو ملف `Reflection_S1_StudentID.pdf` (200–300 كلمة).
   * يرفع **عبدالرحمن** ملف `G##_S1_ID.zip` محتويًا على: `Program.cs`, `Design.pdf`, `README.txt`, `Output.txt`, وملف الـ Reflection الخاص به.
   * يرفع **إيهاب وعمر وسعود** كلٌ ملف `G##_S1_ID.zip` محتويًا على: ملف الـ Reflection الخاص به + ملف `Team.txt`.

---

## 1. الواجهات الإلزامية (Mandatory Interfaces - Checkpoint 1)

*(يجب الالتزام بنفس الأسماء وتوقيعات الدوال حرفياً كما وردت في مواصفات المشروع)*

<table dir="rtl">
  <thead>
    <tr>
      <th align="right">اسم الواجهة</th>
      <th align="right">الدوال والخصائص المطلوبة داخلها</th>
      <th align="right">المسؤول</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td align="right"><strong><code>IProductCatalogue</code></strong></td>
      <td align="left" dir="ltr"><code>Product GetById(string productId);</code></td>
      <td align="right">إيهاب</td>
    </tr>
    <tr>
      <td align="right"><strong><code>IPricingPolicy</code></strong></td>
      <td align="left" dir="ltr"><code>string Name { get; }</code><br><code>decimal Apply(decimal subtotal);</code></td>
      <td align="right">عمر</td>
    </tr>
    <tr>
      <td align="right"><strong><code>IReceiptFormatter</code></strong></td>
      <td align="left" dir="ltr"><code>string Format(OrderSummary summary);</code></td>
      <td align="right">سعود</td>
    </tr>
  </tbody>
</table>

---

## 2. فئات البيانات الأساسية (Data Models - Checkpoint 1)

*(أسماء `Product` و `OrderSummary` إلزامية حرفياً، أما البقية فهي أسماء موحدة للفريق)*

<table dir="rtl">
  <thead>
    <tr>
      <th align="right">اسم الكلاس</th>
      <th align="right">الخصائص (Properties)</th>
      <th align="right">الوصف والمسؤول</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td align="right"><strong><code>Product</code></strong> <em>(إلزامي)</em></td>
      <td align="left" dir="ltr"><code>string Id</code><br><code>string Name</code><br><code>decimal UnitPrice</code></td>
      <td align="right">يمثل المنتج الواحد في الكتالوج (إيهاب)</td>
    </tr>
    <tr>
      <td align="right"><strong><code>OrderLine</code></strong></td>
      <td align="left" dir="ltr"><code>string ProductId</code><br><code>int Quantity</code></td>
      <td align="right">يمثل السطر المطلوب في الطلب من العميل (إيهاب)</td>
    </tr>
    <tr>
      <td align="right"><strong><code>CalculatedLine</code></strong></td>
      <td align="left" dir="ltr"><code>string ProductId</code><br><code>string ProductName</code><br><code>int Quantity</code><br><code>decimal UnitPrice</code><br><code>decimal LineTotal</code></td>
      <td align="right">يمثل السطر بعد حساب سعره وإجماليه (إيهاب)</td>
    </tr>
    <tr>
      <td align="right"><strong><code>OrderSummary</code></strong> <em>(إلزامي)</em></td>
      <td align="left" dir="ltr"><code>IReadOnlyList&lt;CalculatedLine&gt; Lines</code><br><code>string PolicyName</code><br><code>decimal Subtotal</code><br><code>decimal DiscountAmount</code><br><code>decimal FinalTotal</code></td>
      <td align="right">ملخص الطلب النهائي الذي يُمرَّر لمُنسق الفاتورة (إيهاب)</td>
    </tr>
  </tbody>
</table>

</div>