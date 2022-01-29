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
    public class BulletDancerBurn : Template
    {
        public static readonly Guid ID = Guid.Parse("f0dd3ca5-7987-4d89-8177-f570a30c7832");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullet Dancer Burn",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a083d9c4-fc7a-4a9a-96cb-7ff45ac16a47"), Type = TextBlockType.Text, Text = $"The fiery blaze of your weapons combined with your unorthodox technique leaves your opponents with little opportunity to capitalize on any gaps in your defenses, or properly defend themselves against your onslaught. While in {ToMarkdownLink<Models.Entities.Feat>("Bullet Dancer Stance", Feats.Instances.BulletDancerStance.ID)}, when you successfully {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} an opponent with a bayonet or reinforced stock attached to your firearm, the next ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you make against that opponent doesn't trigger reactions that would trigger on a ranged attack, such as {ToMarkdownLink<Models.Entities.Feat>("Attack of Opportunity", Feats.Instances.AttackOfOpportunity.ID)}. While in {ToMarkdownLink<Models.Entities.Feat>("Bullet Dancer Stance", Feats.Instances.BulletDancerStance.ID)}, when you make a successful ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against an opponent within your melee reach using a firearm, the next reinforced stock or bayonet attack attached to that firearm deals an additional 1 fire damage per weapon damage die." };
            yield return new TextBlock { Id = Guid.Parse("977dd310-5551-4802-bb81-f0974c8692f6"), Type = TextBlockType.Text, Text = $"The benefit on your next {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} from either use of Bullet Dancer Burn is lost if not used by the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aa6be898-2646-4d9e-817e-d0c45835cdcb"), Feats.Instances.BulletDancerStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04a9d7bb-465e-461a-a7e5-5dad7f341a20"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
