﻿using cafe.Domain.Client.Entity;
using cafe.Domain.Order.Entity;

namespace cafe.Domain.Table.Entity
{
	public class TableEntity
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public bool Deleted { get; set; }

        public LobbyName LobbyName { get; set; }

		public ClientEntity? Client { get; set; }

        public int? ClientId { get; set; }

		public ICollection<OrderEntity>? Orders { get; set; }
    }
}