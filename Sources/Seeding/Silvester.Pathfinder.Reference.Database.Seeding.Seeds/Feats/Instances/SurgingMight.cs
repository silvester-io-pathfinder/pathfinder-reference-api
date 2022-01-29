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
    public class SurgingMight : Template
    {
        public static readonly Guid ID = Guid.Parse("cb5d5a6d-5ab7-40b1-b668-5df024c2b713");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surging Might",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f045ca52-6a64-4619-ab0a-2150ff85889b"), Type = TextBlockType.Text, Text = $"With a complex gesture, you focus the power of your spell to overcome enemies' resistances. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}, the spell ignores an amount of the target's resistance equal to your level against all the following types of damage: chaotic, evil, good, lawful, negative, and positive. This applies to all damage the spell deals, including persistent damage and damage caused by an ongoing effect of the spell, such as the positive energy within a {ToMarkdownLink<Models.Entities.Spell>("field of life", Spells.Instances.FieldOfLife.ID)}. This doesn't cause the spell to ignore immunities, only resistances." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ab15d4ba-d696-47ea-93d4-85489c841ea2"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76485db4-0272-4066-9fbc-ab19d9fcced1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
