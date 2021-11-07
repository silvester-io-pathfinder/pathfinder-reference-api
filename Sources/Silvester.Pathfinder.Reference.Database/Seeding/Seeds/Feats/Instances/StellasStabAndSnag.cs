using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StellasStabAndSnag : Template
    {
        public static readonly Guid ID = Guid.Parse("f5bfd8d2-a042-4639-b46d-45d97a1f02f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stella's Stab and Snag",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("193e6e55-bcaf-4621-bd5b-46aed1e6e66c"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("740991bc-b929-4f11-9ef7-3689d4d03d5e"), Type = TextBlockType.Text, Text = "You dart towards your opponent, seeking to stab them and slice their purse-strings with a single movement. (action: Stride) up to your Speed; this movement does not trigger reactions triggered by movement. At any point during this movement you can (action: Strike) an opponent within reach. If this (action: Strike) is successful, you can attempt a Thievery check to (action: Steal) from the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c121796f-025e-474f-b89e-36887697d04f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ed589c7-f64c-42af-9125-76d068f37129"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
