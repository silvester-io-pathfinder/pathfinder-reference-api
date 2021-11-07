using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnipingDuoDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("7b7ee944-8991-4a37-b9c7-77971d03b6e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sniping Duo Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the sniping duo archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ca73b79-ca3a-490c-8a91-940ea520c45e"), Type = TextBlockType.Text, Text = "When you take this dedication, choose one willing, non-minion ally to act as your spotter. As part of your training in this archetype, you train your spotter in the necessary habits and techniques to use your abilities automatically; your spotter doesn’t need to spend any feats of their own to grant the effects. You only gain the benefits of your Sniping Duo archetype feats if both you and your spotter are alive and conscious. You and your spotter don’t grant your foes lesser cover against one another’s (action: Strikes|Strike). Whenever you or your spotter successfully (action: Strikes|Strike) a target, the other member of your duo gains a +1 circumstance bonus per weapon damage die on the damage roll of their next (action: Strike) made against that target before the end of their next turn." };
            yield return new TextBlock { Id = Guid.Parse("5ecfbb8a-1954-414f-9600-f324766d663e"), Type = TextBlockType.Text, Text = "You can change your designated spotter by spending 3 days of downtime training with another ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b8df9b72-0969-4693-be4c-1e3412293aad"), or => 
            {
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("e33ce79f-6eff-4120-8fb3-e220a5895515"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Bow.ID);
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("308e2240-af62-416b-b7e7-8ab428cf3cad"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Firearm.ID);
            });
            builder.HaveSpecificSkillProficiency(Guid.Parse("91d8576b-3eaf-4e69-a5ad-50d9b0cb1734"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8fc1898-b412-464a-8ee7-98800374af91"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
