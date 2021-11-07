using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PervasiveSuperstition : Template
    {
        public static readonly Guid ID = Guid.Parse("37873b0c-c5db-47f3-a94e-d1089f59aef5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pervasive Superstition",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08746e15-7d90-4db4-92c4-0f54b656364c"), Type = TextBlockType.Text, Text = "You steep yourself in superstition and practice ancient orc mental exercises for shrugging off the effects of magic. You gain a +1 circumstance bonus to saving throws against spells and magical effects at all times." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("21e1e44f-6748-4870-9a44-7901311e79e5"), Feats.Instances.OrcSuperstition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc733f06-749a-4dab-8eca-c29994ea8256"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
