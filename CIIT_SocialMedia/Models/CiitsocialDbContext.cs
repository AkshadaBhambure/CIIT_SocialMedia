using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CIIT_SocialMedia.Models;

public partial class CiitsocialDbContext : DbContext
{
    public CiitsocialDbContext()
    {
    }

    public CiitsocialDbContext(DbContextOptions<CiitsocialDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblCommentReply> TblCommentReplies { get; set; }

    public virtual DbSet<TblDesignation> TblDesignations { get; set; }

    public virtual DbSet<TblExperience> TblExperiences { get; set; }

    public virtual DbSet<TblLocation> TblLocations { get; set; }

    public virtual DbSet<TblPost> TblPosts { get; set; }

    public virtual DbSet<TblPostCategory> TblPostCategories { get; set; }

    public virtual DbSet<TblPostComment> TblPostComments { get; set; }

    public virtual DbSet<TblPostLike> TblPostLikes { get; set; }

    public virtual DbSet<TblPostShare> TblPostShares { get; set; }

    public virtual DbSet<TblQualification> TblQualifications { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblSpecialization> TblSpecializations { get; set; }

    public virtual DbSet<TblState> TblStates { get; set; }

    public virtual DbSet<TblTechnology> TblTechnologies { get; set; }

    public virtual DbSet<TblTopic> TblTopics { get; set; }

    public virtual DbSet<TblUserDetail> TblUserDetails { get; set; }

    public virtual DbSet<TblUserQualification> TblUserQualifications { get; set; }

    public virtual DbSet<Tblstudent> Tblstudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=115.124.106.98;User Id=ciitsocialuser;Password=CIIT#2025;Database=CIITSocialDB;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ciitsocialuser");

        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__tblCitie__DE9DE000B5A60B5B");

            entity.ToTable("tblCities");

            entity.Property(e => e.CityId).HasColumnName("City_Id");
            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.StateId).HasColumnName("State_Id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");

            entity.HasOne(d => d.State).WithMany(p => p.TblCities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__tblCities__State__4D94879B");
        });

        modelBuilder.Entity<TblCommentReply>(entity =>
        {
            entity.HasKey(e => e.ReplyId).HasName("PK__tblComme__B6633284A079E9AF");

            entity.ToTable("tblCommentReplies");

            entity.Property(e => e.ReplyId).HasColumnName("Reply_Id");
            entity.Property(e => e.CommentId).HasColumnName("Comment_Id");
            entity.Property(e => e.CommentReply)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Comment_Reply");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.LikesCount).HasColumnName("Likes_Count");

            entity.HasOne(d => d.Comment).WithMany(p => p.TblCommentReplies)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FK__tblCommen__Comme__02FC7413");
        });

        modelBuilder.Entity<TblDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__tblDesig__E118822FA5E7CEA5");

            entity.ToTable("tblDesignations");

            entity.Property(e => e.DesignationId).HasColumnName("Designation_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Designation_Name");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TblExperience>(entity =>
        {
            entity.HasKey(e => e.ExperienceId).HasName("PK__tblExper__177FAF4E01B86844");

            entity.ToTable("tblExperiences");

            entity.Property(e => e.ExperienceId).HasColumnName("Experience_Id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Company_Name");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DesignationId).HasColumnName("Designation_Id");
            entity.Property(e => e.EmploymentType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Employment_type");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.JoiningDate).HasColumnName("Joining_Date");
            entity.Property(e => e.LeavingDate).HasColumnName("Leaving_Date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.Designation).WithMany(p => p.TblExperiences)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK__tblExperi__Desig__7A672E12");

            entity.HasOne(d => d.User).WithMany(p => p.TblExperiences)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__tblExperi__User___797309D9");
        });

        modelBuilder.Entity<TblLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__tblLocat__D2BA00E20FF81B6E");

            entity.ToTable("tblLocations");

            entity.Property(e => e.LocationId).HasColumnName("Location_Id");
            entity.Property(e => e.CityId).HasColumnName("City_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.LocationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Location_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");

            entity.HasOne(d => d.City).WithMany(p => p.TblLocations)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__tblLocati__City___5070F446");
        });

        modelBuilder.Entity<TblPost>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__tblPosts__5875F7ADC19FE785");

            entity.ToTable("tblPosts");

            entity.Property(e => e.PostId).HasColumnName("Post_Id");
            entity.Property(e => e.Content)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MediaUrl)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Media_Url");
            entity.Property(e => e.PostName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Post_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UserId).HasColumnName("User_Id");
            entity.Property(e => e.Visibility)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.TblPosts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__tblPosts__User_I__7D439ABD");
        });

        modelBuilder.Entity<TblPostCategory>(entity =>
        {
            entity.HasKey(e => e.PostCategoryId).HasName("PK__tblPostC__54FD2AF8E93C76AA");

            entity.ToTable("tblPostCategories");

            entity.Property(e => e.PostCategoryId).HasColumnName("Post_Category_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.PostCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Post_Category_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TblPostComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__tblPostC__99FC14DB13E9C66D");

            entity.ToTable("tblPostComments");

            entity.Property(e => e.CommentId).HasColumnName("Comment_Id");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.LikesCount).HasColumnName("Likes_Count");
            entity.Property(e => e.PostId).HasColumnName("Post_Id");

            entity.HasOne(d => d.Post).WithMany(p => p.TblPostComments)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__tblPostCo__Post___00200768");
        });

        modelBuilder.Entity<TblPostLike>(entity =>
        {
            entity.HasKey(e => e.LikeId).HasName("PK__tblPostL__A40EE687485D96FE");

            entity.ToTable("tblPostLikes");

            entity.Property(e => e.LikeId).HasColumnName("Like_Id");
            entity.Property(e => e.LikesCount).HasColumnName("Likes_Count");
            entity.Property(e => e.PostId).HasColumnName("Post_Id");

            entity.HasOne(d => d.Post).WithMany(p => p.TblPostLikes)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__tblPostLi__Post___05D8E0BE");
        });

        modelBuilder.Entity<TblPostShare>(entity =>
        {
            entity.HasKey(e => e.PostShareId).HasName("PK__tblPostS__45B30826268850AB");

            entity.ToTable("tblPostShares");

            entity.Property(e => e.PostShareId).HasColumnName("Post_Share_Id");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.PostId).HasColumnName("Post_Id");
            entity.Property(e => e.SharedPlatform)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Shared_Platform");
            entity.Property(e => e.SharedTo).HasColumnName("Shared_To");
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.Post).WithMany(p => p.TblPostShares)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__tblPostSh__Post___08B54D69");

            entity.HasOne(d => d.SharedToNavigation).WithMany(p => p.TblPostShareSharedToNavigations)
                .HasForeignKey(d => d.SharedTo)
                .HasConstraintName("FK__tblPostSh__Share__0A9D95DB");

            entity.HasOne(d => d.User).WithMany(p => p.TblPostShareUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__tblPostSh__User___09A971A2");
        });

        modelBuilder.Entity<TblQualification>(entity =>
        {
            entity.HasKey(e => e.QualificationId).HasName("PK__tblQuali__D0DE2D0F3C748FFB");

            entity.ToTable("tblQualifications");

            entity.Property(e => e.QualificationId).HasColumnName("Qualification_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.QualificationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Qualification_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__tblRoles__D80AB4BBE9169FF4");

            entity.ToTable("tblRoles");

            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Role_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TblSpecialization>(entity =>
        {
            entity.HasKey(e => e.SpecializationId).HasName("PK__tblSpeci__01545FF328B7C8F3");

            entity.ToTable("tblSpecializations");

            entity.Property(e => e.SpecializationId).HasColumnName("Specialization_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.QualificationId).HasColumnName("Qualification_Id");
            entity.Property(e => e.SpecializationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Specialization_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");

            entity.HasOne(d => d.Qualification).WithMany(p => p.TblSpecializations)
                .HasForeignKey(d => d.QualificationId)
                .HasConstraintName("FK__tblSpecia__Quali__5EBF139D");
        });

        modelBuilder.Entity<TblState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__tblState__AF9338F778155658");

            entity.ToTable("tblStates");

            entity.Property(e => e.StateId).HasColumnName("State_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("State_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TblTechnology>(entity =>
        {
            entity.HasKey(e => e.TechnologyId).HasName("PK__tblTechn__AA289BE6FC46BCA0");

            entity.ToTable("tblTechnologies");

            entity.Property(e => e.TechnologyId).HasColumnName("Technology_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.TechnologyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Technology_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TblTopic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__tblTopic__8DEAA40571431D11");

            entity.ToTable("tblTopics");

            entity.Property(e => e.TopicId).HasColumnName("Topic_Id");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.TechnologyId).HasColumnName("Technology_Id");
            entity.Property(e => e.TopicName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Topic_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");

            entity.HasOne(d => d.Technology).WithMany(p => p.TblTopics)
                .HasForeignKey(d => d.TechnologyId)
                .HasConstraintName("FK__tblTopics__Techn__6754599E");
        });

        modelBuilder.Entity<TblUserDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__tblUserD__206D9170DC610267");

            entity.ToTable("tblUserDetails");

            entity.HasIndex(e => e.WhatsAppNo, "UQ__tblUserD__21D2A58666548914").IsUnique();

            entity.HasIndex(e => e.MobileNo, "UQ__tblUserD__60678903DA4FA71D").IsUnique();

            entity.HasIndex(e => e.EmailId, "UQ__tblUserD__B795559E1E12A096").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("User_Id");
            entity.Property(e => e.CurrentAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Current_Address");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.DesignationId).HasColumnName("Designation_Id");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Email_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.LocationId).HasColumnName("Location_Id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Mobile_No");
            entity.Property(e => e.PermenantAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Permenant_Address");
            entity.Property(e => e.Pincode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePhoto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Profile_Photo");
            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            entity.Property(e => e.TopicId).HasColumnName("Topic_Id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UserFullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("User_Full_Name");
            entity.Property(e => e.UserTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Title");
            entity.Property(e => e.WhatsAppNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WhatsApp_No");

            entity.HasOne(d => d.Designation).WithMany(p => p.TblUserDetails)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK__tblUserDe__Desig__6FE99F9F");

            entity.HasOne(d => d.Location).WithMany(p => p.TblUserDetails)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__tblUserDe__Locat__72C60C4A");

            entity.HasOne(d => d.Role).WithMany(p => p.TblUserDetails)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__tblUserDe__Role___70DDC3D8");

            entity.HasOne(d => d.Topic).WithMany(p => p.TblUserDetails)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("FK__tblUserDe__Topic__71D1E811");
        });

        modelBuilder.Entity<TblUserQualification>(entity =>
        {
            entity.HasKey(e => e.UserQualificationId).HasName("PK__tblUserQ__BAD9A0907E347925");

            entity.ToTable("tblUserQualifications");

            entity.Property(e => e.UserQualificationId).HasColumnName("UserQualification_Id");
            entity.Property(e => e.CourseType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Course_Type");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("Deleted_At");
            entity.Property(e => e.EndingYear).HasColumnName("Ending_Year");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("datetime")
                .HasColumnName("Inserted_At");
            entity.Property(e => e.SpecializationId).HasColumnName("Specialization_Id");
            entity.Property(e => e.StartingYear).HasColumnName("Starting_Year");
            entity.Property(e => e.UniversityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("University_Name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.Specialization).WithMany(p => p.TblUserQualifications)
                .HasForeignKey(d => d.SpecializationId)
                .HasConstraintName("FK__tblUserQu__Speci__76969D2E");

            entity.HasOne(d => d.User).WithMany(p => p.TblUserQualifications)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__tblUserQu__User___75A278F5");
        });

        modelBuilder.Entity<Tblstudent>(entity =>
        {
            entity.HasKey(e => e.Rno).HasName("PK__tblstude__C2B7F59B79E98EA2");

            entity.ToTable("tblstudents");

            entity.Property(e => e.Rno).HasColumnName("rno");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.Qualification)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("qualification");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
