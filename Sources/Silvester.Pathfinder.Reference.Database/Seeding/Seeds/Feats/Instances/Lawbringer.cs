using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Lawbringer : Template
    {
        public static readonly Guid ID = Guid.Parse("5670df7f-e312-43da-8ce8-8c0c4d715f71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lawbringer",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("322676c7-907b-44f9-bb45-e248423f8983"), Type = TextBlockType.Text, Text = "You trace your lineage to archons: embodiments of heavenly virtues, guardians of the seven-tiered mountain of Heaven, and nurturers of law and virtue within mortals. Your own virtue and orderly mind protect you from foes who would turn your emotions against you. You gain a +1 circumstance bonus to saves against emotion effects, and if you roll a success on a save against an (trait: emotion) effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c461c1f-b6eb-4fad-b40e-177b45e9a249"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
