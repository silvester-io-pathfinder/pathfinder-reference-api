using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LinkedFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("0d093575-8cbb-4c6d-b47a-76c656cbd993");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Linked Focus",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19d43905-2e63-4647-a961-dd0764b8483c"), Type = TextBlockType.Text, Text = "You have linked your bonded item to the well of energy that powers your school spells. When you (Action: Drain your Bonded Item | Drain Bonded Item) to cast a spell of your arcane school, you also regain 1 Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("23074ea9-c710-4d9f-9a6c-804c04a46629"), ClassFeatures.Wizards.ArcaneBond.ID);
            builder.HaveSpecificClassFeature(Guid.Parse("50e5578d-8e50-4e2b-bb95-bd0fd164eb56"), ClassFeatures.Wizards.ArcaneSchool.ID);
            builder.HaveAnyMagicSchool(Guid.Parse("163634af-5620-444f-9dde-83177f534bcc"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1df64d0-e63e-46de-ae03-db79b9d38b0c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
