using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticSwordTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("ada0c923-0d61-4172-bff2-a24ee17a72c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Sword Training",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3de04edf-f72e-461a-9d95-f5b8d14c8019"), Type = TextBlockType.Text, Text = "You were always taught that you needed to be able to use whatever weapon came your way. You can change any of the swords designated in your (feat: Tengu Weapon Familiarity) to different swords that meet the same specifications. You have to practice with a sword during your daily preparations to designate it, and the designation only lasts until your next daily preparations. This changes only your proficiency; it doesn&#39;t change your access." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6e007f54-592c-45ad-accf-753bb24b0d3a"), Feats.Instances.TenguWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82161e64-7e01-450a-ae34-fb74b1f2a37b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
