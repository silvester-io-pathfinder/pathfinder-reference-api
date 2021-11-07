using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Pride : Template
    {
        public static readonly Guid ID = Guid.Parse("2fb52740-aa23-4998-89e5-467dbb516a76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pride",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5919630-0c04-4479-8dc5-1aa7596529e9"), Type = TextBlockType.Text, Text = "All is well as long as you appear well, but you get caught up in the moment and lose track of what’s important." };
            yield return new TextBlock { Id = Guid.Parse("bc1b5357-3aa1-40d2-9533-fad1f573f518"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You critically fail on an attack roll or saving throw." };
            yield return new TextBlock { Id = Guid.Parse("70d6dac7-00bf-4450-9619-f3c03f05cd0b"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: The critical failure becomes a failure." };
            yield return new TextBlock { Id = Guid.Parse("0d418a97-4490-4141-8961-a0f3bbb73642"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Each time you cast an illusion spell, until the start of your next turn, any critical failure you roll on an attack roll or saving throw is a failure instead. Spell: (spell: color spray)" };
            yield return new TextBlock { Id = Guid.Parse("e7af872c-7bd9-4283-a9b7-8197c5276b1a"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You momentarily lose track of what’s real, becoming confused for 1 round. Spell: (spell: mirror image)" };
            yield return new TextBlock { Id = Guid.Parse("6a8b2050-a28c-4ea2-a9d5-4539d03cf3f1"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: veil of confidence)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05a61040-9883-4460-bcd6-e0ac38f242b2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
