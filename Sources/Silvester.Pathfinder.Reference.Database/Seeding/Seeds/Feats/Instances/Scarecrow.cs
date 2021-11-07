using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Scarecrow : Template
    {
        public static readonly Guid ID = Guid.Parse("67bf9cda-0e14-42d8-bfbb-42a69ea1bd32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scarecrow",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ec5b9ad-04cd-4c02-8cef-734cef3e5c14"), Type = TextBlockType.Text, Text = "You fight fiercely to protect your crop. When you hit a creature that is adjacent to two or more members of your crop with a weapon or unarmed attack, you gain a circumstance bonus to your damage roll equal to the number of weapon damage dice. When you hit a creature who has a member of your crop grabbed, that member can attempt to (action: Escape) using a reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a53848c-9dc4-4728-8017-a76523fde30b"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dba7158-4df5-45e5-8421-c5b88ee2fff7"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
