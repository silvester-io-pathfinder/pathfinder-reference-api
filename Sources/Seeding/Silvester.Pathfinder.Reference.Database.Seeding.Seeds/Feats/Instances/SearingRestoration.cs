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
    public class SearingRestoration : Template
    {
        public static readonly Guid ID = Guid.Parse("851ef2c2-49ba-419a-a59b-aaf660d9710d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Searing Restoration",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you, though because it's not a living creature, it can't use the ability on itself.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fedc7f7-006b-493b-9261-6abc81ee5f9e"), Type = TextBlockType.Text, Text = $"They told you there was no way that explosions could heal people, but they were fools… Fools who didn't understand your brilliance! You create a minor explosion from your innovation, altering the combustion to cauterize wounds using vaporized medicinal herbs. You or a living creature adjacent to you regains 1d10 Hit Points. In addition, the creature you heal can attempt an immediate flat check to recover from a single source of persistent bleed damage, with the DC reduction from appropriate assistance." };
            yield return new TextBlock { Id = Guid.Parse("018ee33b-78fc-4a78-8bcc-e64bc2932e39"), Type = TextBlockType.Text, Text = $"At 3rd level, and every 2 levels thereafter, increase the healing by 1d10." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Inventor.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Unstable.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0427bd1c-1550-4169-931f-ea9051bdd938"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
