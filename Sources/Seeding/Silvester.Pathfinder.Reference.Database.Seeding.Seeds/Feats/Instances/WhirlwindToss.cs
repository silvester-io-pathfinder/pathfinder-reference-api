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
    public class WhirlwindToss : Template
    {
        public static readonly Guid ID = Guid.Parse("2e7ed388-f732-4528-bd65-10961da9c0f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Toss",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79525620-c8ef-41cb-80a5-906d203a7b3e"), Type = TextBlockType.Text, Text = $"You whirl a foe to smash into all nearby creatures before throwing them far away in imitation of the techniques of your rival, Ran-To. You {ToMarkdownLink<Models.Entities.Feat>("Thrash", Feats.Instances.Thrash.ID)}. During this {ToMarkdownLink<Models.Entities.Feat>("Thrash", Feats.Instances.Thrash.ID)}, your {ToMarkdownLink<Models.Entities.Feat>("Collateral Thrash", Feats.Instances.CollateralThrash.ID)} feat applies to all foes adjacent to you. You can then throw the grabbed creature 10 feet, where they fall prone." };
            yield return new TextBlock { Id = Guid.Parse("260bef35-4a0a-4996-9f6b-0e9036e80072"), Type = TextBlockType.Text, Text = $"If the foe you choose for {ToMarkdownLink<Models.Entities.Feat>("Collateral Thrash", Feats.Instances.CollateralThrash.ID)} is also adjacent to you, they attempt only one save and take the damage only once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d2f86cad-f380-4f49-9325-9bb59bab9e0f"), Feats.Instances.CollateralThrash.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a41a0672-9bc8-4d55-a02b-2c2d177052da"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
