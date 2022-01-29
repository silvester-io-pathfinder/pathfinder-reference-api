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
    public class OverwhelmingEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("b8fcf956-9679-4547-85c9-0b3e1f3ffb0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwhelming Energy",
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
            yield return new TextBlock { Id = Guid.Parse("1e802702-8eb3-4811-8057-d761573d602b"), Type = TextBlockType.Text, Text = $"With a complex gesture, you call upon the primal power of your spell to overcome enemies' resistances. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}, the spell ignores an amount of the target's resistance to acid, cold, electricity, fire, or sonic damage equal to your level. This applies to all damage the spell deals, including persistent damage and damage caused by an ongoing effect of the spell, such as the wall created by {ToMarkdownLink<Models.Entities.Spell>("wall of fire", Spells.Instances.WallOfFire.ID)}. A creature's immunities are unaffected." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8a06aab-a9dd-407b-95b2-a076de772d73"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
