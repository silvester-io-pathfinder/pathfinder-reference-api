using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowTheBeat : Template
    {
        public static readonly Guid ID = Guid.Parse("7dea6e16-4e57-43b6-90a5-c1b42f20bd3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Know the Beat",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("265585a4-a3ef-499e-9b77-f17523aab709"), Type = TextBlockType.Text, Text = "You become trained in your choice of Guild Lore, Legal Lore, Mercantile Lore, or Underworld Lore. You gain a +1 circumstance bonus to Diplomacy checks to (action: Gather Information) and to checks made to investigate crimes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("acd60810-4187-4094-afe2-b5c9fa0b3e89"), Feats.Instances.ZephyrGuardDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("992fe1ba-8678-4864-b20e-d9f958952a5f"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
