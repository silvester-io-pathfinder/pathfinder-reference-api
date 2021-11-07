using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmiteGood : Template
    {
        public static readonly Guid ID = Guid.Parse("d134de4e-4a08-4297-9cc0-ad07bcd5a9b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smite Good",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c37da8aa-1f60-4eb3-804e-74cf1dee009a"), Type = TextBlockType.Text, Text = "Your blade ally shares your lust for the blood of good creatures. Select one enemy you can see. Until the start of your next turn, your (action: Strikes | Strike) against that foe using the weapon your blade ally inhabits deal an extra 4 evil damage, increasing to 6 if you have master proficiency with this weapon." };
            yield return new TextBlock { Id = Guid.Parse("72398e23-980d-424f-8555-02bab1825637"), Type = TextBlockType.Text, Text = "If the chosen enemy attacks you before the start of your next turn, the duration extends to the end of that enemy’s next turn. If the enemy continues to attack you each turn, the duration continues to extend." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("4266c465-d161-4beb-91e2-8d6d367b4c71"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("e422ec52-9749-43a0-8431-3d729adfcb9b"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5f46430-2181-4478-89a4-40a557e80365"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
