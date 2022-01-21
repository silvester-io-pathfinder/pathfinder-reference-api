using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WanderingHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("48a01a6b-73c3-4e91-90e9-2f6155e14e3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wandering Heart",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8032ea09-a8f4-4c2f-b1c9-40092c18ce34"), Type = TextBlockType.Text, Text = "While all elves adapt to their environments over time, you have traveled so widely and become attuned to so many environs that your body now changes more rapidly than other elves. After spending a week in an environment associated with an elf heritage (such as snow for arctic elf, or a forest or jungle for woodland elf) your heritage automatically changes to become that heritage. This never causes you to change to an elf heritage that isn't related to an environment, such as ancient elf, seer elf, or whisper elf." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d61d6dac-441e-4cbb-b060-aab6cded696b"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("c358cffd-5b9e-403b-a4c8-10de020bf11f"), Heritages.Instances.ArcticElf.ID);
                or.HaveSpecificHeritage(Guid.Parse("5afaf7d7-e86a-4b3f-9704-32c7d4dd35c8"), Heritages.Instances.CavernElf.ID);
                or.HaveSpecificHeritage(Guid.Parse("0beeffc0-24ef-430b-b4a8-b8ffaf572002"), Heritages.Instances.DesertElf.ID);
                or.HaveSpecificHeritage(Guid.Parse("5edab80e-2d0b-42de-a414-3a319f92f68a"), Heritages.Instances.WoodlandElf.ID);
                or.Manual(Guid.Parse("8086715b-e862-4645-9046-428a8bb009ca"), "Any other elf heritage based on adapting to an environment.");
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f6914e5-0d9c-42d3-b318-3a01ea14902c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
