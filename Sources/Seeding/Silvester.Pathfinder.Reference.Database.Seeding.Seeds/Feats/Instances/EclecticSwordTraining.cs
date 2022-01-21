using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticSwordTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("3ffec0cd-5ce7-4735-ae41-9ea98b362cd5");

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
            yield return new TextBlock { Id = Guid.Parse("5ed13214-c55a-400b-bb97-da32ce70c3ca"), Type = TextBlockType.Text, Text = $"You were always taught that you needed to be able to use whatever weapon came your way. You can change any of the swords designated in your {ToMarkdownLink<Models.Entities.Feat>("Tengu Weapon Familiarity", Feats.Instances.TenguWeaponFamiliarity.ID)} to different swords that meet the same specifications. You have to practice with a sword during your daily preparations to designate it, and the designation only lasts until your next daily preparations. This changes only your proficiency; it doesn't change your access." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("086178f4-173f-4a60-b328-4fae05457663"), Feats.Instances.TenguWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcbe5f5d-ff1f-4980-8c81-96951c054aa5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
