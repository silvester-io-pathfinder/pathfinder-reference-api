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
    public class SteamSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("581b0418-6abb-41e2-9984-216f44da050c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steam Spell",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5009fc82-545a-4456-9a3b-dac7757f157e"), Type = TextBlockType.Text, Text = $"You transform your fire spells into steam, making them more effective underwater. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} with the {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)} trait, you can cast it underwater. When you do so, it takes the form of scalding steam. Underwater creatures do not gain the normal fire resistance for being underwater against this spell, but they don't light things on fire or cause persistent fire damage, nor do they add other effects that would apply to fire but not steam (at the GM's discretion)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Undine.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("258c1c1d-b027-44b6-8abe-f1d99b584464"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
