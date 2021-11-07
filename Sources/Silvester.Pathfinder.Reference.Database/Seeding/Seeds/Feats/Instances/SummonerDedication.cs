using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("09bf74ab-6e56-4f51-a9f4-248d92fd2aaf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summoner Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the summoner archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb497b11-973a-4d9f-9b30-511a215aff4b"), Type = TextBlockType.Text, Text = "You’ve formed a bond with an eidolon, an entity that manifests in a physical body only through its link to your life force. Your bond may be tenuous, but that doesn’t make your connection any less special. You gain an eidolon (SoM pg. 52) as well as the (action: Manifest Eidolon) activity. Due to your tenuous link, you can’t gain or use (trait: tandem) actions. Because you don’t have (action: Act Together), only you or your eidolon can perform an exploration activity at one time, so for instance you couldn’t both be (action: Searching | Search) or (action: Investigating | Investigate)." };
            yield return new TextBlock { Id = Guid.Parse("1ce59010-d112-4d72-9527-0f9217eb80bf"), Type = TextBlockType.Text, Text = "Your eidolon is trained in unarmed attacks and unarmored defense, and shares your proficiency rank for Perception, saving throws, and skill checks. Choose an eidolon type. You become trained in your eidolon’s listed skills. For each of those skills that you are already trained in, you become trained in a different skill of your choice. Your eidolon&#39;s initial ability scores are reduced. It starts with a 16 in any ability score listed at 18 for its eidolon array. It otherwise gains the statistics listed for an eidolon of that type." };
            yield return new TextBlock { Id = Guid.Parse("124a8e00-5c18-444c-af6d-2f5939234066"), Type = TextBlockType.Text, Text = "At 5th level, the eidolon’s ability score that was reduced to 16 increases to 18, before applying ability boosts. At levels 5, 10, 15, and 20, your eidolon also gets four ability boosts, which follow the same rules as yours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("accd42cd-192a-4213-8211-171c48ce0d7b"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16a181ff-e7c6-445e-8210-d6d72b3b9033"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
