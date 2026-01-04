using Domain;

var lift = Elevator.Create();

lift.AddRequest(5);
lift.AddRequest(3);
lift.AddRequest(2);

lift.ProcessRequest();