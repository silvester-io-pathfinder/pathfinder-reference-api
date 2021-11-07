using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SupernaturalSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("c4c0940f-2629-4e9f-b359-50f9f131f702");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Supernatural Senses",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("323501af-d1d2-4322-8a7c-c740797ff4a7"), Type = TextBlockType.Text, Text = "Your scent is preternaturally sharp, and you can always rely on your sense of smell to help guide you when your vision is compromised. When you target a concealed or hidden opponent while you are raging, you reduce the DC of the flat check to 3 for a concealed target or to 9 for a hidden one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("52b1a840-e5d8-40ac-ae7a-fb6f30b1481a"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("4779a471-afb3-4101-a012-9d83e73d0262"), Feats.Instances.AcuteScent.ID);
                or.HaveSpecificSense(Guid.Parse("f468a1c2-8461-4d16-977e-243bff13150f"), Senses.Instances.Scent.ID);
                or.HaveSpecificSense(Guid.Parse("792f3327-d100-42d8-abf6-f355d6c86dc9"), Senses.Instances.Scent.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f59fa566-574b-40dd-ad73-35ada70d12e8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
