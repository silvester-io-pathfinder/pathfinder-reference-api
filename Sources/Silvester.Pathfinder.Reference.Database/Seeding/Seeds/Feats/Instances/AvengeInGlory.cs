using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AvengeInGlory : Template
    {
        public static readonly Guid ID = Guid.Parse("ba07a335-0ab4-4fe2-a510-5e7e9a36f490");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Avenge in Glory",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet gains the dying condition.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddb03e24-586d-44af-92ee-f8ef8270af38"), Type = TextBlockType.Text, Text = "~ Access: mountain dwarf ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("626a2927-6d45-4d21-9b4d-5808cc16abfd"), Type = TextBlockType.Text, Text = "You honor your ally’s life, gaining temporary Hit Points equal to your level for 1 minute. As long as you have these temporary Hit Points, you gain a +1 circumstance bonus to attack and damage rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce7e24d4-a480-4656-89b4-85af3b6ec19c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
