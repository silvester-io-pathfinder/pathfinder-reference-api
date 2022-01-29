using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1869cf83-a9ad-4a1d-949e-65b8cf641ebf");

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
            yield return new TextBlock { Id = Guid.Parse("8f2d6097-ccf5-4b59-8d44-d5588ef85a45"), Type = TextBlockType.Text, Text = $"You've formed a bond with an eidolon, an entity that manifests in a physical body only through its link to your life force. Your bond may be tenuous, but that doesn't make your connection any less special. You gain an eidolon (SoM pg. 52) as well as the {ToMarkdownLink<Models.Entities.Feat>("Manifest Eidolon", Feats.Instances.ManifestEidolon.ID)} activity. Due to your tenuous link, you can't gain or use {ToMarkdownLink<Models.Entities.Trait>("tandem", Traits.Instances.Tandem.ID)} actions. Because you don't have {ToMarkdownLink<Models.Entities.Feat>("Act Together", Feats.Instances.ActTogether.ID)}, only you or your eidolon can perform an exploration activity at one time, so for instance you couldn't both be {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)} or {ToMarkdownLink<Models.Entities.Activity>("Investigating", Activities.Instances.Investigate.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("4b4b3cfa-4bcb-48dc-9136-5a708e7cb197"), Type = TextBlockType.Text, Text = $"Your eidolon is trained in unarmed attacks and unarmored defense, and shares your proficiency rank for Perception, saving throws, and skill checks. Choose an eidolon type. You become trained in your eidolon's listed skills. For each of those skills that you are already trained in, you become trained in a different skill of your choice. Your eidolon's initial ability scores are reduced. It starts with a 16 in any ability score listed at 18 for its eidolon array. It otherwise gains the statistics listed for an eidolon of that type." };
            yield return new TextBlock { Id = Guid.Parse("3fdc5eac-ef87-4eb0-8441-20419c2f0999"), Type = TextBlockType.Text, Text = $"At 5th level, the eidolon's ability score that was reduced to 16 increases to 18, before applying ability boosts. At levels 5, 10, 15, and 20, your eidolon also gets four ability boosts, which follow the same rules as yours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("89f37c6a-44f6-43f6-98e8-32e53b741ab6"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6c78707-3288-4cb8-9aec-94a9e2fa7462"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
