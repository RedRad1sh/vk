﻿// Autogenerated at 27.05.2014 10:14:48
// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY
using VkNet.Model;
using VkNet.Model.Attachments;
using System.Collections.ObjectModel;
namespace VkNet.Utils
{
    partial class VkResponse
    {
		public static implicit operator AccountInfo(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  AccountInfo.FromJson(response);
        }

		public static implicit operator Collection<AccountInfo>(VkResponse response)
        {
            return response.ToCollectionOf<AccountInfo>(a => a);
        }
		public static implicit operator Album(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Album.FromJson(response);
        }

		public static implicit operator Collection<Album>(VkResponse response)
        {
            return response.ToCollectionOf<Album>(a => a);
        }
		public static implicit operator ApplicationContent(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  ApplicationContent.FromJson(response);
        }

		public static implicit operator Collection<ApplicationContent>(VkResponse response)
        {
            return response.ToCollectionOf<ApplicationContent>(a => a);
        }
		public static implicit operator Attachment(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Attachment.FromJson(response);
        }

		public static implicit operator Collection<Attachment>(VkResponse response)
        {
            return response.ToCollectionOf<Attachment>(a => a);
        }
		public static implicit operator Audio(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Audio.FromJson(response);
        }

		public static implicit operator Collection<Audio>(VkResponse response)
        {
            return response.ToCollectionOf<Audio>(a => a);
        }
		public static implicit operator AudioAlbum(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  AudioAlbum.FromJson(response);
        }

		public static implicit operator Collection<AudioAlbum>(VkResponse response)
        {
            return response.ToCollectionOf<AudioAlbum>(a => a);
        }
		public static implicit operator BanInfo(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  BanInfo.FromJson(response);
        }

		public static implicit operator Collection<BanInfo>(VkResponse response)
        {
            return response.ToCollectionOf<BanInfo>(a => a);
        }
		public static implicit operator ChangeNameRequest(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  ChangeNameRequest.FromJson(response);
        }

		public static implicit operator Collection<ChangeNameRequest>(VkResponse response)
        {
            return response.ToCollectionOf<ChangeNameRequest>(a => a);
        }
		public static implicit operator Chat(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Chat.FromJson(response);
        }

		public static implicit operator Collection<Chat>(VkResponse response)
        {
            return response.ToCollectionOf<Chat>(a => a);
        }
		public static implicit operator City(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  City.FromJson(response);
        }

		public static implicit operator Collection<City>(VkResponse response)
        {
            return response.ToCollectionOf<City>(a => a);
        }
		public static implicit operator Comment(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Comment.FromJson(response);
        }

		public static implicit operator Collection<Comment>(VkResponse response)
        {
            return response.ToCollectionOf<Comment>(a => a);
        }
		public static implicit operator Comments(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Comments.FromJson(response);
        }

		public static implicit operator Collection<Comments>(VkResponse response)
        {
            return response.ToCollectionOf<Comments>(a => a);
        }
		public static implicit operator Connections(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Connections.FromJson(response);
        }

		public static implicit operator Collection<Connections>(VkResponse response)
        {
            return response.ToCollectionOf<Connections>(a => a);
        }
		public static implicit operator Coordinates(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Coordinates.FromJson(response);
        }

		public static implicit operator Collection<Coordinates>(VkResponse response)
        {
            return response.ToCollectionOf<Coordinates>(a => a);
        }
		public static implicit operator Counters(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Counters.FromJson(response);
        }

		public static implicit operator Collection<Counters>(VkResponse response)
        {
            return response.ToCollectionOf<Counters>(a => a);
        }
		public static implicit operator Country(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Country.FromJson(response);
        }

		public static implicit operator Collection<Country>(VkResponse response)
        {
            return response.ToCollectionOf<Country>(a => a);
        }
		public static implicit operator Document(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Document.FromJson(response);
        }

		public static implicit operator Collection<Document>(VkResponse response)
        {
            return response.ToCollectionOf<Document>(a => a);
        }
		public static implicit operator Education(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Education.FromJson(response);
        }

		public static implicit operator Collection<Education>(VkResponse response)
        {
            return response.ToCollectionOf<Education>(a => a);
        }
		public static implicit operator Faculty(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Faculty.FromJson(response);
        }

		public static implicit operator Collection<Faculty>(VkResponse response)
        {
            return response.ToCollectionOf<Faculty>(a => a);
        }
		public static implicit operator FriendList(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  FriendList.FromJson(response);
        }

		public static implicit operator Collection<FriendList>(VkResponse response)
        {
            return response.ToCollectionOf<FriendList>(a => a);
        }
		public static implicit operator Geo(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Geo.FromJson(response);
        }

		public static implicit operator Collection<Geo>(VkResponse response)
        {
            return response.ToCollectionOf<Geo>(a => a);
        }
		public static implicit operator Graffiti(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Graffiti.FromJson(response);
        }

		public static implicit operator Collection<Graffiti>(VkResponse response)
        {
            return response.ToCollectionOf<Graffiti>(a => a);
        }
		public static implicit operator Group(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Group.FromJson(response);
        }

		public static implicit operator Collection<Group>(VkResponse response)
        {
            return response.ToCollectionOf<Group>(a => a);
        }
		public static implicit operator LastActivity(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  LastActivity.FromJson(response);
        }

		public static implicit operator Collection<LastActivity>(VkResponse response)
        {
            return response.ToCollectionOf<LastActivity>(a => a);
        }
		public static implicit operator Likes(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Likes.FromJson(response);
        }

		public static implicit operator Collection<Likes>(VkResponse response)
        {
            return response.ToCollectionOf<Likes>(a => a);
        }
		public static implicit operator Link(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Link.FromJson(response);
        }

		public static implicit operator Collection<Link>(VkResponse response)
        {
            return response.ToCollectionOf<Link>(a => a);
        }
		public static implicit operator LongPollServerResponse(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  LongPollServerResponse.FromJson(response);
        }

		public static implicit operator Collection<LongPollServerResponse>(VkResponse response)
        {
            return response.ToCollectionOf<LongPollServerResponse>(a => a);
        }
		public static implicit operator Lyrics(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Lyrics.FromJson(response);
        }

		public static implicit operator Collection<Lyrics>(VkResponse response)
        {
            return response.ToCollectionOf<Lyrics>(a => a);
        }
		public static implicit operator Message(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Message.FromJson(response);
        }

		public static implicit operator Collection<Message>(VkResponse response)
        {
            return response.ToCollectionOf<Message>(a => a);
        }
		public static implicit operator Note(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Note.FromJson(response);
        }

		public static implicit operator Collection<Note>(VkResponse response)
        {
            return response.ToCollectionOf<Note>(a => a);
        }
		public static implicit operator Page(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Page.FromJson(response);
        }

		public static implicit operator Collection<Page>(VkResponse response)
        {
            return response.ToCollectionOf<Page>(a => a);
        }
		public static implicit operator Photo(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Photo.FromJson(response);
        }

		public static implicit operator Collection<Photo>(VkResponse response)
        {
            return response.ToCollectionOf<Photo>(a => a);
        }
		public static implicit operator PhotosList(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  PhotosList.FromJson(response);
        }

		public static implicit operator Collection<PhotosList>(VkResponse response)
        {
            return response.ToCollectionOf<PhotosList>(a => a);
        }
		public static implicit operator Place(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Place.FromJson(response);
        }

		public static implicit operator Collection<Place>(VkResponse response)
        {
            return response.ToCollectionOf<Place>(a => a);
        }
		public static implicit operator Poll(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Poll.FromJson(response);
        }

		public static implicit operator Collection<Poll>(VkResponse response)
        {
            return response.ToCollectionOf<Poll>(a => a);
        }
		public static implicit operator PollAnswer(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  PollAnswer.FromJson(response);
        }

		public static implicit operator Collection<PollAnswer>(VkResponse response)
        {
            return response.ToCollectionOf<PollAnswer>(a => a);
        }
		public static implicit operator Post(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Post.FromJson(response);
        }

		public static implicit operator Collection<Post>(VkResponse response)
        {
            return response.ToCollectionOf<Post>(a => a);
        }
		public static implicit operator PostSource(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  PostSource.FromJson(response);
        }

		public static implicit operator Collection<PostSource>(VkResponse response)
        {
            return response.ToCollectionOf<PostSource>(a => a);
        }
		public static implicit operator Previews(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Previews.FromJson(response);
        }

		public static implicit operator Collection<Previews>(VkResponse response)
        {
            return response.ToCollectionOf<Previews>(a => a);
        }
		public static implicit operator Region(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Region.FromJson(response);
        }

		public static implicit operator Collection<Region>(VkResponse response)
        {
            return response.ToCollectionOf<Region>(a => a);
        }
		public static implicit operator Relative(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Relative.FromJson(response);
        }

		public static implicit operator Collection<Relative>(VkResponse response)
        {
            return response.ToCollectionOf<Relative>(a => a);
        }
		public static implicit operator RepostResult(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  RepostResult.FromJson(response);
        }

		public static implicit operator Collection<RepostResult>(VkResponse response)
        {
            return response.ToCollectionOf<RepostResult>(a => a);
        }
		public static implicit operator Reposts(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Reposts.FromJson(response);
        }

		public static implicit operator Collection<Reposts>(VkResponse response)
        {
            return response.ToCollectionOf<Reposts>(a => a);
        }
		public static implicit operator School(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  School.FromJson(response);
        }

		public static implicit operator Collection<School>(VkResponse response)
        {
            return response.ToCollectionOf<School>(a => a);
        }
		public static implicit operator StandInLife(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  StandInLife.FromJson(response);
        }

		public static implicit operator Collection<StandInLife>(VkResponse response)
        {
            return response.ToCollectionOf<StandInLife>(a => a);
        }
		public static implicit operator Status(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Status.FromJson(response);
        }

		public static implicit operator Collection<Status>(VkResponse response)
        {
            return response.ToCollectionOf<Status>(a => a);
        }
		public static implicit operator Street(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Street.FromJson(response);
        }

		public static implicit operator Collection<Street>(VkResponse response)
        {
            return response.ToCollectionOf<Street>(a => a);
        }
		public static implicit operator Tag(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Tag.FromJson(response);
        }

		public static implicit operator Collection<Tag>(VkResponse response)
        {
            return response.ToCollectionOf<Tag>(a => a);
        }
		public static implicit operator University(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  University.FromJson(response);
        }

		public static implicit operator Collection<University>(VkResponse response)
        {
            return response.ToCollectionOf<University>(a => a);
        }
		public static implicit operator User(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  User.FromJson(response);
        }

		public static implicit operator Collection<User>(VkResponse response)
        {
            return response.ToCollectionOf<User>(a => a);
        }
		public static implicit operator Video(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  Video.FromJson(response);
        }

		public static implicit operator Collection<Video>(VkResponse response)
        {
            return response.ToCollectionOf<Video>(a => a);
        }
		public static implicit operator VideoAlbum(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  VideoAlbum.FromJson(response);
        }

		public static implicit operator Collection<VideoAlbum>(VkResponse response)
        {
            return response.ToCollectionOf<VideoAlbum>(a => a);
        }
		public static implicit operator VkObject(VkResponse response)
		{
            return response == null || response._token == null || !response._token.HasValues ? null :  VkObject.FromJson(response);
        }

		public static implicit operator Collection<VkObject>(VkResponse response)
        {
            return response.ToCollectionOf<VkObject>(a => a);
        }

	}
}