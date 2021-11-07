using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialForm : Template
    {
        public static readonly Guid ID = Guid.Parse("bc80c840-351e-4512-9ff8-59e7d8cea882");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Form",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d76b80a-53b9-4955-ae97-97e3e242ba28"), Type = TextBlockType.Text, Text = "You take on a celestial countenance, appearing like a type of celestial who serves your deity; for example, as an angel, you would gain a halo and feathery wings. You gain a fly Speed equal to your Speed. You gain darkvision if you don’t already have it, and you gain the (trait: celestial) trait and the trait appropriate to the type of servitor you’ve become (archon, angel, or azata, for example)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("63a19f0e-bf68-4672-aaa2-49c703848200"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c7287ed-ac26-45e0-a793-15f235b8d82f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
