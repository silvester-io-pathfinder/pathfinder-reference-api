using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Forager : Template
    {
        public static readonly Guid ID = Guid.Parse("4d346006-3ba3-488b-a40b-4e856ee00c1f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forager",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1745f830-564a-4efc-bb10-1561aa9a9723"), Type = TextBlockType.Text, Text = "While using Survival to (Action: Subsist), if you roll any result worse than a success, you get a success. On a success, you can provide subsistence living for yourself and four additional creatures, and on a critical success, you can take care of twice as many creatures as on a success." };
            yield return new TextBlock { Id = Guid.Parse("dc847c10-a765-4de9-b794-65c18392acdc"), Type = TextBlockType.Text, Text = "Each time your proficiency rank in Survival increases, double the number of additional creatures you can take care of on a success (to eight if you're an expert, 16 if you're a master, or 32 if you're legendary). You can choose to care for half the number of additional creatures and provide a comfortable living instead of subsistence living." };
            yield return new TextBlock { Id = Guid.Parse("d826bdeb-44bc-4ea7-8599-f365d31a4bd6"), Type = TextBlockType.Text, Text = "Multiple smaller creatures or creatures with significantly smaller appetites than a human are counted as a single creature for this feat, and larger creatures or those with significantly greater appetites each count as multiple creatures. The GM determines how much a non-human creature needs to eat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5be89da1-7a1b-4180-9c33-1694ffa10be4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9baa669c-cb8e-49a8-9c9b-fc17bbd065a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
