# FunWithGRPC

När skall olika protokoll användas:

HTTP = externt
grpc = internt i microservice system när synkront
Kafka = (möjligen RabbitMQ) internt i microservice miljö vid asynkront.

grpc vs HTTP: grpc är 10x snabbare till priset att server client måste känna till varandra och prata ett specat protokoll.



