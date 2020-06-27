# Farklı Saat Dilimleri için Sunucu İstemci DateTime İletimi

Sunucu istemci arasındaki olası saat dilimi farkları kullanılan uygulamalarda zaman karmaşasına yol açmaktadır. Bu karmaşıklığı engellemek için birçok farklı yöntem uygulanmaktadır. Bu örnek sunucu ve istemcinin birbirinden bağımsız zaman dilimlerinde ve birbiriyle zaman dilimi alışveri olmadan çalışmasını esas almıştır.

-Sunucu datetime objelerini UTC zamanına göre timestamp olarak yollar 
-İstemci tarayıcıdan gelen zaman dilimi bilgisini sunucudan gelen timestamp bilgisine ekler.

# Server-Client DateTime Connection for Diffrent Time Zones

Different time zone between server and client leads to time confusing. There are diffrent solutions for this problem. This tutorial target that no communication beetwen server and client for time zone.

-Server sends timestamp that converted for UTC
-Client converts this timestamp and adding to local timezone information