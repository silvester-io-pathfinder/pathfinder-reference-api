using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("8b64ac83-caa2-4a71-bdd8-8adabfee66b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Guide",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39467fdc-462f-455c-b9af-acba62468f24"), Type = TextBlockType.Text, Text = $"You know the wilderness so well that you can help your party travel through it with ease. When you are setting the path for your party through wilderness terrain, your party gains a +10-foot circumstance bonus to its Speed for the purpose of calculating the party's travel speed, your party's travel speed doesn't decrease in difficult terrain, and greater difficult terrain halves your party's travel speed instead of reducing it to a third. This doesn't increase your party's Speed during an encounter or allow your party to ignore difficult terrain during an encounter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("45e5baee-3590-4315-b455-42e17ad4bb18"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fe46f66-79de-45f2-91a6-3ae50c84caf0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
