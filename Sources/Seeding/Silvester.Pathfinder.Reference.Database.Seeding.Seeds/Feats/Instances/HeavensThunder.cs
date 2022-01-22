using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeavensThunder : Template
    {
        public static readonly Guid ID = Guid.Parse("cce84ede-5620-4097-b54b-71d563873f5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heaven's Thunder",
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
            yield return new TextBlock { Id = Guid.Parse("249a7f6d-d9a4-4715-9c33-703fe9316310"), Type = TextBlockType.Text, Text = $"With a loud shout, you unleash your ki in a crackling shroud of thunder and lightning that engulfs your body. Until the end of your next turn, your unarmed attacks and weapons you wield that have the {ToMarkdownLink<Models.Entities.Trait>("monk", Traits.Instances.Monk.ID)} trait deal additional electricity damage equal to one-half your level and additional sonic damage equal to one-half your level." };
            yield return new TextBlock { Id = Guid.Parse("c782b13e-fb0a-4548-90f2-fee379420f81"), Type = TextBlockType.Text, Text = $"If you also know the {ToMarkdownLink<Models.Entities.Spell>("ki blast", Spells.Instances.KiBlast.ID)} ki spell, you can choose to deal either electricity or sonic damage with the spell instead of force while this effect is active ({ToMarkdownLink<Models.Entities.Spell>("ki blast", Spells.Instances.KiBlast.ID)} loses the {ToMarkdownLink<Models.Entities.Trait>("force", Traits.Instances.Force.ID)} trait and gains the {ToMarkdownLink<Models.Entities.Trait>("electricity", Traits.Instances.Electricity.ID)} or {ToMarkdownLink<Models.Entities.Trait>("sonic", Traits.Instances.Sonic.ID)} trait instead). Any creature who successfully {ToMarkdownLink<Models.Entities.SkillAction>("Grapples", SkillActions.Instances.Grapple.ID)} you or is successfully {ToMarkdownLink<Models.Entities.SkillAction>("Grappled", SkillActions.Instances.Grapple.ID)} by you also takes this damage immediately after the {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)} check is resolved." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc7693f1-c30a-46e7-ae19-538359ea660d"), Feats.Instances.JalmeriHeavenseekerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35b9efc3-2c51-4fcc-8d2e-de477161b8ae"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
