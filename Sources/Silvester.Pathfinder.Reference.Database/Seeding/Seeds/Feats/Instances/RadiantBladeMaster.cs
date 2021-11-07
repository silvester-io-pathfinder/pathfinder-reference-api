using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RadiantBladeMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("914506c3-60a8-46a0-92fd-5685debee4e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Blade Master",
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
            yield return new TextBlock { Id = Guid.Parse("147851d6-15e6-4114-9158-8070610ac5c0"), Type = TextBlockType.Text, Text = "Your divine ally turns your chosen weapon into a paragon of its type. When you choose the weapon for your blade divine ally during your preparations, add the following property runes to the list of effects you can choose from: (item: dancing | Dancing Runestone), (item: greater disrupting | Greater Disrupting Runestone), and (item: keen | Keen Runestone)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("d307f2b7-746c-4268-b574-7a5749a5c9a4"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificFeat(Guid.Parse("590015fb-03b3-4eb6-9953-5fedb17c2d32"), Feats.Instances.RadiantBladeSpirit.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48c47e2c-069a-47c0-9316-b8c033b1adb9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
