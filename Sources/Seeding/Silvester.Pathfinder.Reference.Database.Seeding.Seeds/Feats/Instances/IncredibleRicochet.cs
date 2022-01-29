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
    public class IncredibleRicochet : Template
    {
        public static readonly Guid ID = Guid.Parse("1afcce80-768b-4761-a5db-75992fd2b704");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Ricochet",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e8a294a-43b8-4032-b274-51475a1a88e2"), Type = TextBlockType.Text, Text = $"After your first shot singles out your opponent's position, you direct another that ricochets around obstacles and strikes unerringly. Make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a creature you previously attacked this turn. You ignore the target's concealed condition and all cover." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("438b49be-3d0d-4bc4-9549-41eebfb416ea"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("efd51491-bb63-45f4-8de7-1d0f85718c31"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("0ab0a994-de2a-4bca-a021-0214fb4db990"), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e71cad71-d72d-4fa3-909e-4f585cb25fd7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
