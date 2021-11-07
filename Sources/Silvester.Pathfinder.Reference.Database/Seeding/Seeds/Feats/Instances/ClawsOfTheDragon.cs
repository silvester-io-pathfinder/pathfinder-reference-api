using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClawsOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("3b48fce8-5754-4dad-8685-ef7fcb6b9507");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Claws of the Dragon",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e061c7ae-df2b-44f5-a303-163d0da9e89f"), Type = TextBlockType.Text, Text = "Your fingernails grow into razor-sharp claws, and scales speckle your fingers, hands, and wrists. Your claws are (trait: agile), (trait: finesse) unarmed attacks that deal 1d6 slashing damage and are in the brawling weapon group." };
            yield return new TextBlock { Id = Guid.Parse("95d58a91-4a0d-4f70-948c-fbe64b70f54c"), Type = TextBlockType.Text, Text = "If you’re a draconic sorcerer, when you cast (spell: dragon claws), increase the spell’s slashing damage die from d4 to d6 and increase the resistance to 10 at 1st level, 15 at 5th level, and 20 at 9th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("752d3a6a-dada-41eb-81a4-b769d03be042"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd1f83e1-7f41-4385-b5df-aeb70861c42f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
