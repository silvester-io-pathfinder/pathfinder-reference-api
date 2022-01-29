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
    public class PushIt : Template
    {
        public static readonly Guid ID = Guid.Parse("52a14704-7a20-428d-b6e6-9bf0549d2872");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Push It",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27bc332d-41f0-4328-b4f3-515405ced687"), Type = TextBlockType.Text, Text = $"You can push your vehicle's performance beyond the limits envisioned by its makers. Whenever you succeed at a piloting check, the vehicle you are piloting gains a +5-foot circumstance bonus to all its Speeds until the end of your turn. If you critically succeed, this bonus increases to +10 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0cbab076-263a-480f-a62f-bf59a70b9782"), Feats.Instances.TrickDriverDedication.ID);
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("614a1ab2-8f3e-482d-8e09-d0421a961809"), Proficiencies.Instances.Master.ID, Lores.Instances.Driving.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("970e21d1-6379-4133-bec3-b10c11b11aa6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
