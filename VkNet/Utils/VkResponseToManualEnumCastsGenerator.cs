﻿// Autogenerated at 27.05.2014 10:14:46
// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY
using VkNet.Enums;
namespace VkNet.Utils
{
    partial class VkResponse
    {
		public static implicit operator AddFriendStatus(VkResponse response)
		{
			if (response == null)
				return AddFriendStatus.Unknown;
			return Utilities.EnumFrom<AddFriendStatus>(response);
		}

		public static implicit operator Attitude(VkResponse response)
		{
			if (response == null)
				return Attitude.Unknown;
			return Utilities.EnumFrom<Attitude>(response);
		}

		public static implicit operator BanReason(VkResponse response)
		{
			if (response == null)
				return BanReason.Other;
			return Utilities.EnumFrom<BanReason>(response);
		}

		public static implicit operator DeleteFriendStatus(VkResponse response)
		{
			if (response == null)
				return DeleteFriendStatus.Unknown;
			return Utilities.EnumFrom<DeleteFriendStatus>(response);
		}

		public static implicit operator FriendStatus(VkResponse response)
		{
			if (response == null)
				return FriendStatus.NotFriend;
			return Utilities.EnumFrom<FriendStatus>(response);
		}

		public static implicit operator LifeMain(VkResponse response)
		{
			if (response == null)
				return LifeMain.Unknown;
			return Utilities.EnumFrom<LifeMain>(response);
		}

		public static implicit operator PeopleMain(VkResponse response)
		{
			if (response == null)
				return PeopleMain.Unknown;
			return Utilities.EnumFrom<PeopleMain>(response);
		}

		public static implicit operator PoliticalPreferences(VkResponse response)
		{
			if (response == null)
				return PoliticalPreferences.Unknown;
			return Utilities.EnumFrom<PoliticalPreferences>(response);
		}

		public static implicit operator RelationType(VkResponse response)
		{
			if (response == null)
				return RelationType.Unknown;
			return Utilities.EnumFrom<RelationType>(response);
		}

		public static implicit operator Sex(VkResponse response)
		{
			if (response == null)
				return Sex.Unknown;
			return Utilities.EnumFrom<Sex>(response);
		}


	}
}