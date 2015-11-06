﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ball_of_Duty_Server.Domain;
using Ball_of_Duty_Server.DTO;
using Ball_of_Duty_Server.Persistence;

namespace Ball_of_Duty_Server.Services
{
    [ServiceContract]
    public interface IBoDService
    {
        [OperationContract]
        PlayerDTO NewGuest(string nickname);

        [OperationContract]
        GameDTO JoinGame(int clientPlayerId, int clientPort);

        [OperationContract]
        void QuitGame(int clientPlayerId);
        [OperationContract]
        int RequestBulletCreation(double x, double y, double radius, double damage, int ownerId, int gameId);
    }
}