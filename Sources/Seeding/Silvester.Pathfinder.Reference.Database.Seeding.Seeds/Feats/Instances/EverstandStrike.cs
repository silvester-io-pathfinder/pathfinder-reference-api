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
    public class EverstandStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3681f687-55fa-4cc8-95d8-1cdb501c1b40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everstand Strike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e344755-71ee-47fd-8a29-74c6fbde7690"), Type = TextBlockType.Text, Text = $"~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("573bac65-9fad-44ce-a7c8-3c7c58369241"), Type = TextBlockType.Text, Text = $"Your follow-up blow leaves you an opening to set your shield. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the wielded shield. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits and deals damage, you also {ToMarkdownLink<Models.Entities.Action>("Raise your Shield", Actions.Instances.RaiseAShield.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("295d75de-2d23-427b-9268-0c2da2fc365a"), Feats.Instances.EverstandStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a358d247-231c-4828-ba02-1236e63cf6a8"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("86ef94ed-5758-404a-ac0c-33b758d16864"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("5bd6ec75-4181-4a7a-b6b8-58c5ab6c8a57"), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("560f20b0-787a-4c55-83dc-6da91da7bfbb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
