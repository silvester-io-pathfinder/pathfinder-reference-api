using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EchoingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("9405c706-b93c-46d2-931c-3196a341167b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Echoing Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5241426b-3d43-46e8-bc30-77951b6c3748"), Type = TextBlockType.Text, Text = $"You time the components of your spell with exacting precision, setting up a resonance that duplicates the spell's effects. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} of 4th level or lower that has no duration, the spell's energy reverberates and echoes. You can {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} a second time before the end of your next turn without expending a spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a0eaa8e8-30ee-4e23-8729-b8dbf0b8153d"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f013ec39-c858-4186-abf6-5cbcb16becd7"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("62da7841-e721-431c-9fb6-83b933ae53ba"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("1425b1c8-a919-4342-b58a-dfb7d3703aeb"), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65dfe36f-2885-4ad0-9635-20cfa85cfd63"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
