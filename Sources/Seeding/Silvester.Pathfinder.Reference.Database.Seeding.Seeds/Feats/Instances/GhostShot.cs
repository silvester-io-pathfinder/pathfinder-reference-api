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
    public class GhostShot : Template
    {
        public static readonly Guid ID = Guid.Parse("cea00e69-a49a-4767-9ce2-dfbda21c7a03");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("570a9715-2cfd-4bd4-92aa-8f4e4a4fe254"), Type = TextBlockType.Text, Text = $"Make a firearm or crossbow {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you're hidden from or undetected by the target, the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} adds the additional precision damage from {ToMarkdownLink<Models.Entities.Feat>("One Shot, One Kill", Feats.Instances.OneShotOneKill.ID)}; if you would already receive that additional damage on the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, the effects aren't cumulative. If you were undetected or unnoticed by any creatures, you're now hidden from them instead, as the origin of the attack is clear." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bbdea83-5bbb-4158-8474-d07c7158d722"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
