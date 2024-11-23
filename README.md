# Pratik - Basic MVC
Görev: Müşteri ve Sipariş Bilgilerini Görüntüleme

Aşağıdaki adımları izleyerek, ASP.NET MVC kullanarak bir müşteri ve sipariş bilgilerini görüntülemek için bir uygulama geliştiriyoruz.

## Aşama 1: Model Oluşturma

 1- Customer Modeli:

 * Bir Customer sınıfı oluşturun.
 * Id (Müşterinin benzersiz kimliği, int türünde)
 * FirstName (Müşterinin adı, string türünde)
 * LastName (Müşterinin soyadı, string türünde)
 * Email (Müşterinin e-posta adresi, string türünde)

 2- Order Modeli:
 
 * Bir Order sınıfı oluşturun.
 * Id (Siparişin benzersiz kimliği, int türünde)
 * ProductName (Ürünün adı, string türünde)
 * Price (Ürünün fiyatı, decimal türünde) 
 * Quantity (Sipariş edilen ürün miktarı, int türünde)

## Aşama 2: ViewModel Oluşturma

 1- CustomerOrderViewModel Sınıfı:

 * Bir CustomerOrderViewModel sınıfı oluşturun.
 * Customer (Bir Customer nesnesi)
 * Orders (Bir Order nesneleri listesi)
 * ViewModel, model verilerini ve view'da göstermek için gerekli ek bilgileri bir arada tutacaktır.

## Aşama 3: Controller Oluşturma

 1- CustomerOrdersController:

 * Bir CustomerOrdersController sınıfı oluşturun.
 * Bu controller içinde, Index adında bir aksiyon metodu oluşturun.
 * Index metodunda:
 * Örnek bir Customer nesnesi ve birkaç Order nesnesi oluşturun.
 * Bu nesneleri kullanarak bir CustomerOrderViewModel nesnesi oluşturun.
 * CustomerOrderViewModel nesnesini view'a iletin.

## Aşama 4: View Oluşturma
 1- Index View:

 * Views/CustomerOrders klasörü altında bir Index.cshtml adlı view oluşturun.
 * Bu view, CustomerOrderViewModel kullanarak müşteri bilgilerini ve siparişleri gösterecek.
 * View’da:
 * Müşteri bilgilerini (ID, adı, soyadı, e-posta) görüntüleyin.
 * Siparişlerin bir tablosunu oluşturun ve sipariş ID'si, ürün adı, fiyat ve miktar bilgilerini listeleyin.

   
