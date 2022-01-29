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
    public class Cling : Template
    {
        public static readonly Guid ID = Guid.Parse("5ba9f62e-70e0-430f-ae2c-a4b94a810420");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cling",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this action without a free hand if your preceding Strike was made with your jaws or a similar unarmed attack you could use to hang on. The GM determines which unarmed attacks apply. Hanging on in this way prevents you from using that unarmed attack.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("449200ce-d55f-46a0-9057-823049179403"), Type = TextBlockType.Text, Text = $"You hang onto a foe to harry them into submission. If your target moves while you're hanging onto it, you can choose to move with the target. The target is released if you choose not to move with it, at the start of your next turn, or if the target {ToMarkdownLink<Models.Entities.Action>("Escapes", Actions.Instances.Escape.ID)}. Attempts to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} from a Cling follow the rules for {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)}, but use your Acrobatics DC and end the Cling instead of the conditions normally ended by the {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} action." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ecf3a47-d4f6-47a2-bad3-7942bcdc15b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
