using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerBurn : Template
    {
        public static readonly Guid ID = Guid.Parse("d8d9ba3a-c96c-4c71-b33e-8c8fc39fb162");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullet Dancer Burn",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ca38c06-db56-4596-8a6e-40a6f4b7c370"), Type = TextBlockType.Text, Text = "The fiery blaze of your weapons combined with your unorthodox technique leaves your opponents with little opportunity to capitalize on any gaps in your defenses, or properly defend themselves against your onslaught. While in (feat: Bullet Dancer Stance), when you successfully (action: Strike) an opponent with a bayonet or reinforced stock attached to your firearm, the next ranged (action: Strike) you make against that opponent doesn’t trigger reactions that would trigger on a ranged attack, such as (feat: Attack of Opportunity). While in (feat: Bullet Dancer Stance), when you make a successful ranged (action: Strike) against an opponent within your melee reach using a firearm, the next reinforced stock or bayonet attack attached to that firearm deals an additional 1 fire damage per weapon damage die." };
            yield return new TextBlock { Id = Guid.Parse("372c6b3b-454b-418c-b145-16e8d0e8430c"), Type = TextBlockType.Text, Text = "The benefit on your next (action: Strike) from either use of Bullet Dancer Burn is lost if not used by the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e681b17f-93e5-42b6-824a-c2e4066da496"), Feats.Instances.BulletDancerStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7115248d-c8b9-4c32-95e7-8b0a16776a36"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
