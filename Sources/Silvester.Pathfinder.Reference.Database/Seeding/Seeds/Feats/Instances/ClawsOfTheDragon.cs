using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClawsOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("af4449a9-5f0f-4c45-95e4-696a64322aa3");

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
            yield return new TextBlock { Id = Guid.Parse("7e071c6f-11ae-4fcf-8212-694d76816a08"), Type = TextBlockType.Text, Text = "Your fingernails grow into razor-sharp claws, and scales speckle your fingers, hands, and wrists. Your claws are (trait: agile), (trait: finesse) unarmed attacks that deal 1d6 slashing damage and are in the brawling weapon group." };
            yield return new TextBlock { Id = Guid.Parse("a20cab0c-b1c8-468e-9f97-80001544e1f8"), Type = TextBlockType.Text, Text = "If you’re a draconic sorcerer, when you cast (spell: dragon claws), increase the spell’s slashing damage die from d4 to d6 and increase the resistance to 10 at 1st level, 15 at 5th level, and 20 at 9th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb8bc939-0e62-4eab-af18-982a4acb9920"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc14cf36-d112-403e-ba64-9270db56b11a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
