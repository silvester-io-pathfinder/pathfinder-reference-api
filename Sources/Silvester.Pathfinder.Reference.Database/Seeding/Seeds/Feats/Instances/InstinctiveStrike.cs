using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstinctiveStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("511396e2-d629-4bf6-a844-6a435f0d9e0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instinctive Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6864715-8422-4611-a3e1-e3ab53d67409"), Type = TextBlockType.Text, Text = "You trust your instincts and your sense of smell, using all of your senses to pinpoint your opponent’s location. Make a melee (action: Strike) against an opponent that isn’t hiding its scent with an effect like (spell: negate aroma). This attack ignores any flat check required due to the target being concealed or hidden." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("00765e65-db6d-4269-a9a1-333341117953"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("40c38dde-35bb-413f-9e20-4a26dbecd58c"), Feats.Instances.AcuteScent.ID);
                or.HaveSpecificSense(Guid.Parse("0ff0fc5a-6c38-45b8-9df8-b193ac903672"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Precise.ID);
                or.HaveSpecificSense(Guid.Parse("3a4224c8-7d70-4652-88ac-49c28c8cc87e"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID);
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
                Id = Guid.Parse("ff4d9f61-f72b-4d56-a2db-4101e36babcf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
